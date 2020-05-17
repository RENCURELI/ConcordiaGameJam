using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

//Manage Player Movement
public class PlayerMovement : MonoBehaviour
{
    #region Variables

    public UnityEvent m_PromptEventEnable;
    public UnityEvent m_PromptEventDisable;

    Controller controls;

    private Rigidbody2D m_Rigidbody2D;

    /// <summary>
    /// Value used to define the number of inputs to restart light
    /// </summary>
    private int m_Reignite = 0;
    private int m_InputCount = 0;

    private bool m_LadderMove = false;
    public bool g_AuthorizeMoveToggle = false;

    Vector2 m_Move;

    LightLifespan m_Torch;

    #endregion

    private void Awake()
    {
        if (m_PromptEventEnable == null)
        {
            m_PromptEventEnable = new UnityEvent();
        }
        if (m_PromptEventDisable == null)
        {
            m_PromptEventDisable = new UnityEvent();
        }

        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        controls = new Controller();

        controls.Movement.Move.performed += ctx => m_Move = ctx.ReadValue<Vector2>();
        controls.Movement.Move.canceled += ctx => m_Move = Vector2.zero;

        controls.Movement.LightOn.performed += ctx => Reignite();

        controls.Movement.Interactions.performed += ctx => ToggleLadder();

        m_Torch = FindObjectOfType<LightLifespan>();
        m_LadderMove = false;
    }

    private void Update()
    {
        if (m_LadderMove == false)
        {
            Vector2 m = new Vector2(m_Move.x, m_Move.y) * Time.deltaTime;
            transform.Translate(m, Space.World);
        }

        if (m_LadderMove != false)
        {
            Vector2 m = new Vector2(m_Move.x, m_Move.y) * Time.deltaTime;
            transform.Translate(m, Space.World);
        }
        
        if (m_Torch.g_lifeSpan <= 0 && m_Reignite == 0)
        {
            m_Reignite = Random.Range(3, 7);
            m_PromptEventEnable.Invoke();
        }

        if (m_InputCount > m_Reignite)
        {
            m_Torch.g_lifeSpan = 100;
            m_InputCount = 0;
            m_Reignite = 0;
            m_PromptEventDisable.Invoke();
        }

    }

    private void OnEnable()
    {
        controls.Movement.Enable();
    }

    private void OnDisable()
    {
        controls.Movement.Disable();
    }

    #region Functions

    private int Reignite()
    {
        m_InputCount++;
        return m_InputCount;
    }

    private void ToggleLadder()
    {
        if (g_AuthorizeMoveToggle == true)
        {
            if (m_LadderMove != true)
            {
                m_LadderMove = true;
                LadderMovement();
            }
            else
            {
                m_LadderMove = false;
                LadderMovement();
            }
        }
    }

    private float Normalize(int min, int max, int val)
    {
        float m_Normalized = (val - min) / (max - min);

        return m_Normalized;
    }

    public void LadderMovement()
    {
        if (m_LadderMove == true)
        {
            //Send character to ladder Z position
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.9f);

            //Freeze Y movement (allow to climb)
            m_Rigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionY;
            return;
        }
        else
        {
            //Send character back to foreground
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.9f);

            //Unfreeze Y movement (allow to climb)
            m_Rigidbody2D.constraints = RigidbodyConstraints2D.None;
            m_Rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
            return;
        }
    }

    #endregion
}

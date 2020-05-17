using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

//Manage player lightsource lifespan
public class LightLifespan : MonoBehaviour
{
    #region Variables

    const int MAXLIGHT = 100;
    public float g_lifeSpan = MAXLIGHT;

    [SerializeField]
    private float m_DecreaseRate = 5f;

    private Light2D m_Light;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        g_lifeSpan = MAXLIGHT;
        m_Light = this.GetComponent<Light2D>();
        m_Light.intensity = Normalize(0, MAXLIGHT, g_lifeSpan);
    }

    // Update is called once per frame
    void Update()
    {

        if (g_lifeSpan >= 0)
        {
            g_lifeSpan -= m_DecreaseRate * Time.deltaTime;
        }

        m_Light.intensity = Normalize(0, MAXLIGHT, g_lifeSpan);
    }

    #region Functions

    float Normalize(int min, int max, float val)
    {
        float m_Normalized = (val - min) / (max - min);

        return m_Normalized;
    }
    

    #endregion
}

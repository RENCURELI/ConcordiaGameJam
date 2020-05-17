using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LadderInteract : MonoBehaviour
{
    public UnityEvent g_ShowPrompt;
    public UnityEvent g_HidePrompt;

    private PlayerMovement m_Player;

    private void Start()
    {
        if (g_ShowPrompt == null)
        {
            g_ShowPrompt = new UnityEvent();
        }
        if (g_HidePrompt == null)
        {
            g_HidePrompt = new UnityEvent();
        }

        m_Player = FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        g_ShowPrompt.Invoke();
        m_Player.g_AuthorizeMoveToggle = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        g_HidePrompt.Invoke();
        m_Player.g_AuthorizeMoveToggle = false;
    }
}

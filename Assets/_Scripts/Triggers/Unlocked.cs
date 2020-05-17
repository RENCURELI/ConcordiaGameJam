using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocked : MonoBehaviour
{
    private bool m_Unlocked = false;

    // Update is called once per frame
    void Update()
    {
        if (m_Unlocked == true)
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    public void Unlock()
    {
        if (m_Unlocked == false)
            m_Unlocked = true;
        else
            m_Unlocked = false;
    }
}

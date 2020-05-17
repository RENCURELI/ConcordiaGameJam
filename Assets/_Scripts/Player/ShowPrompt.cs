using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{

    private Image m_Image;

    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
        m_Image.enabled = false;
    }
    

    public void EnableImage()
    {
        m_Image.enabled = true;
    }

    public void DisableImage()
    {
        m_Image.enabled = false;
    }
}

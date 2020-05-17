using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIClamp : MonoBehaviour
{
    public Image Bimage;
    public Image Aimage;

    // Update is called once per frame
    void Update()
    {
        Vector3 imagePos = Camera.main.WorldToScreenPoint(this.transform.position);
        Bimage.transform.position = imagePos;
        Aimage.transform.position = imagePos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickUp : MonoBehaviour
{
    public UnityEvent g_UnlockDoor;

    // Start is called before the first frame update
    void Start()
    {
        if (g_UnlockDoor == null)
        {
            g_UnlockDoor = new UnityEvent();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        g_UnlockDoor.Invoke();

        Destroy(this.gameObject);
    }
}

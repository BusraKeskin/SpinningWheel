using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinTrigger : MonoBehaviour
{
    public WheelTrigger wTrigger;
    public static PinTrigger instance;

    private void Awake()
    {
        instance = this;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
      
        if (col.gameObject.CompareTag("WheelTrigger")) 
        {
            wTrigger = col.GetComponent<WheelTrigger>();
        }
    }
   
}

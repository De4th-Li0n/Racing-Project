using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTriger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "CarPlayer")
        {
            LapCompleteTrig.SetActive(true);
            HalfLapTrig.SetActive(false);
        }    
    }
}
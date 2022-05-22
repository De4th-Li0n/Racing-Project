using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour
{
    void OnTriggerEnter(Collider collision){    
    if (collision.gameObject.tag == "CarPlayer")
	{
        ModeScore.CurrentScore += 50;
        gameObject.SetActive(false);
    }
    }
}

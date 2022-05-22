using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour
{
   void OnTriggerEnter(Collider collision){
    if (collision.gameObject.tag == "CarPlayer")
	{
        ModeScore.CurrentScore += 100;
        gameObject.SetActive(false);
    }
   }
}

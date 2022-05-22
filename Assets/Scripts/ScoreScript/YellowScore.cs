using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour
{
    void OnTriggerEnter(Collider collision){
    if (collision.gameObject.tag == "CarPlayer")
	{
        ModeScore.CurrentScore += 25;
        gameObject.SetActive(false);
    }
    }
}

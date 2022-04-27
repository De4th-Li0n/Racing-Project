using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTriger : MonoBehaviour
{
	public GameObject StartTrig;
	public GameObject NextTrig;

	void OnTriggerEnter()
	{
		StartTrig.SetActive(true);
		NextTrig.SetActive(false);
	}
}

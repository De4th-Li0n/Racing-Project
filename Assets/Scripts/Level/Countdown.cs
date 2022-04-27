using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


public class Countdown : MonoBehaviour
{
	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;	
	public GameObject CarUserControl;
	public GameObject AICar01;

	void Start()
	{
		StartCoroutine(CountStart());
		CarUserControl.GetComponent<CarUserControl>().enabled = false;
		AICar01.GetComponent<CarAIControl>().enabled = false;
	}


	IEnumerator CountStart()
	{		
		yield return new WaitForSeconds(0.5f);
		CountDown.GetComponent<Text>().text = "3";
		GetReady.Play();
		CountDown.SetActive(true);

		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "2";
		GetReady.Play();
		CountDown.SetActive(true);

		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "1";
		GetReady.Play();
		CountDown.SetActive(true);

		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		GoAudio.Play();
		LapTimer.SetActive(true);

		CarUserControl.GetComponent<CarUserControl>().enabled = true;
		AICar01.GetComponent<CarAIControl>().enabled = true;
	}
}


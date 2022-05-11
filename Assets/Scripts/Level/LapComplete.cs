using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject NextTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapCounter;
    public int LapsDone;
    public float RawTime;

    public GameObject RaceFinish;

    void Update() 
    {
        if(LapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "CarPlayer")
		{
            LapsDone += 1;

            RawTime = PlayerPrefs.GetFloat("RawTime");

        if (LaptimeManager.RawTime <= RawTime)
        {

            if (LaptimeManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LaptimeManager.SecondCount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<Text>().text = "" + LaptimeManager.SecondCount + ".";
            }

            if (LaptimeManager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LaptimeManager.MinuteCount + ".";
            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + LaptimeManager.MinuteCount + ".";
            }

            MilliDisplay.GetComponent<Text>().text = "" + LaptimeManager.MilliCount;
        }

        PlayerPrefs.SetInt("MinSave", LaptimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LaptimeManager.SecondCount);
        PlayerPrefs.SetFloat("MiliSave", LaptimeManager.MilliCount);
        PlayerPrefs.SetFloat("RawTime", LaptimeManager.RawTime);

        LaptimeManager.MinuteCount = 0;
        LaptimeManager.SecondCount = 0;
        LaptimeManager.MilliCount = 0;
        LaptimeManager.RawTime = 0;

        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        NextTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

        }
    }
}

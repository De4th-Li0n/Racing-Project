using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
    public GameObject PinkButton;
    public GameObject YellowButton;
    public int cashValue;

	void Update () {
        cashValue = GlobalCash.TotalCash;
        if (cashValue >= 100)
        {
            PinkButton.GetComponent<Button>().interactable = true;
        }
        if (cashValue >= 200)
        {
            YellowButton.GetComponent<Button>().interactable = true;
        }
	}

    public void PinkUnlock()
    {
        PinkButton.SetActive(false);
        cashValue -= 100;
        GlobalCash.TotalCash -= 100;
        PlayerPrefs.SetInt("Saved Cash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("Pink Bought", 100);
    }
    public void YellowUnlock()
    {
        YellowButton.SetActive(false);
        cashValue -= 200;
        GlobalCash.TotalCash -= 200;
        PlayerPrefs.SetInt("Saved Cash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("Yellow Bought", 200);
    }
}

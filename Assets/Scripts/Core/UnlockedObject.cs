using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObject : MonoBehaviour
{
    public int PinkSelect;
    public int YellowSelect;
    public GameObject FakePink;
    public GameObject FakeYellow;

	void Start () {
        PinkSelect = PlayerPrefs.GetInt("Pink Bought");
        if (PinkSelect == 100)
        {
            FakePink.SetActive(false);
        }
        YellowSelect = PlayerPrefs.GetInt("Yellow Bought");
        if (YellowSelect == 200)
        {
            FakeYellow.SetActive(false);
        }
	}
}

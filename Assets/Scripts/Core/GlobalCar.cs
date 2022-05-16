using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    // Start is called before the first frame update
    public static int CarType; //1=Red, 2=Pale, 3=Yellow, 4=Pink
    public GameObject TrackWindow;

    public void RedCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void PaleCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }
    public void YellowCar()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }
    public void PinkCar()
    {
        CarType = 4;
        TrackWindow.SetActive(true);
    }
}

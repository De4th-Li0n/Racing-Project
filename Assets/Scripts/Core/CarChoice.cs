using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    //1=Red, 2=Pale, 3=Yellow, 4=Pink
    public GameObject RedCar;
    public GameObject PaleCar;
    public GameObject YellowCar;
    public GameObject PinkCar;
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            RedCar.SetActive(true);
        }

        if (CarImport == 2)
        {
            PaleCar.SetActive(true);
        }
        if (CarImport == 3)
        {
            YellowCar.SetActive(true);
        }
        if (CarImport == 4)
        {
            PinkCar.SetActive(true);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour
{
	public GameObject Car;
	public float CarPosX;
	public float CarPosY;
	public float CarPosZ;

    public void Update()
    {
        CarPosX = Car.transform.eulerAngles.x;
        CarPosY = Car.transform.eulerAngles.y;
        CarPosZ = Car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarPosX - CarPosX, CarPosY, CarPosZ - CarPosZ);
    }
}

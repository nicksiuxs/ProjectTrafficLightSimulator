using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reducer : MonoBehaviour
{
    public GameObject trafficLight;

    private void OnTriggerEnter(Collider other)
    {

        if (trafficLight.GetComponent<TrafficLightController>().isRed == true)
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(0f);
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (trafficLight.GetComponent<TrafficLightController>().isRed == true)
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(0f);
        }
        if (trafficLight.GetComponent<TrafficLightController>().isRed == false)
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(10f);
        }
    }
}

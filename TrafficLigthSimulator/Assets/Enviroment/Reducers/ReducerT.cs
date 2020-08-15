using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducerT : MonoBehaviour
{
    public GameObject trafficLight;
    public Waypoint waypoint1;
    // public Waypoint waypoint2;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint1;
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
        if (trafficLight.GetComponent<TrafficLightController>().isRed == false && trafficLight.GetComponent<TrafficLightController>().isYellow == false )
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(10f);
        }
    }
}

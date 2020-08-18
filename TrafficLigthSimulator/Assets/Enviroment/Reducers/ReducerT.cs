using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducerT : MonoBehaviour
{
        public GameObject trafficLight;
    public Waypoint waypoint1;
    public Waypoint waypoint2;
    public Waypoint waypoint3;
    public Waypoint waypoint4;
    public Waypoint waypoint5;
    public Waypoint waypoint6;

    public int random;

    private void OnTriggerEnter(Collider other)
    {
        random = Random.Range(1, 6);
        switch (random)
        {
            case 1:
                other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint1;
                break;
            case 2:
                other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint2;
                break;
            case 3:
                other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint3;
                break;
            case 4:
                other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint4;
                break;
            case 5:
                other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint5;
                break;
            case 6:
                other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint6;
                break;
        }

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
        if (trafficLight.GetComponent<TrafficLightController>().isRed == false && trafficLight.GetComponent<TrafficLightController>().isYellow == false)
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(10f);
        }
    }
}

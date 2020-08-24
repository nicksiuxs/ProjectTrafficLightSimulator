using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducerT : MonoBehaviour
{
    public GameObject trafficLight;
    public Waypoint waypoint1;
    public Waypoint waypoint2;

    public int random;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            random = Random.Range(1, 3);
            // Debug.Log(random);

            switch (random)
            {
                case 1:
                    other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint1;
                    break;
                case 2:
                    other.GetComponent<WaypointNavigator>().currentWaypoint = waypoint2;
                    break;
                case 3:
                    break;
            }

            if (trafficLight.GetComponent<TrafficLightController>().isRed == true)
            {
                other.GetComponent<CharacterNavigationController>().setMovementSpeed(0f);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
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
}

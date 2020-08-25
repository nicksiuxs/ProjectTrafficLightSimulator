using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidewalk : MonoBehaviour
{
    public GameObject tf1;
    public GameObject tf2;
    public Waypoint waypoint1;
    public Waypoint waypoint2;
    public Waypoint waypoint3;
    int random;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entre");

        other.GetComponent<CharacterNavigationController>().setMovementSpeed(0f);


        if (other.CompareTag("Pedestrian") && tf1.GetComponent<TrafficLightController>().isRed && tf2.GetComponent<TrafficLightController>().isRed)
        {
            random = Random.Range(1, 4);
            Debug.Log(random);
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
                    break;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (tf1.GetComponent<TrafficLightController>().isGreen || tf2.GetComponent<TrafficLightController>().isGreen)
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(0f);
        }

        if (tf1.GetComponent<TrafficLightController>().isRed && tf2.GetComponent<TrafficLightController>().isRed)
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(5f);
        }
    }
}

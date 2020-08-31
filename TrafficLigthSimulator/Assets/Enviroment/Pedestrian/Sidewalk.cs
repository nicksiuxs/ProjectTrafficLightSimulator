using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidewalk : MonoBehaviour
{
    public GameObject tf1;
    public GameObject tf2;
    public GameObject tf3;
    public GameObject tf4;
    public Waypoint waypoint1;
    public Waypoint waypoint2;
    public Waypoint waypoint3;
    int random;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pedestrian"))
        {
            other.GetComponent<PedestrianController>().setMovementSpeed(0f);
            Debug.Log("Detenido");
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (tf1.GetComponent<TrafficLightController>().isRed && tf2.GetComponent<TrafficLightController>().isRed &&
        tf3.GetComponent<TrafficLightController>().isRed && tf4.GetComponent<TrafficLightController>().isRed)
        {
            random = Random.Range(1, 4);
            Debug.Log(random);

            switch (random)
            {
                case 1:
                    other.GetComponent<WaypointPedestrianNavigator>().setCurrentWaypoint(waypoint1);
                    other.GetComponent<PedestrianController>().setMovementSpeed(Random.Range(1.4f, 1.5f));
                    break;
                case 2:
                    other.GetComponent<WaypointPedestrianNavigator>().setCurrentWaypoint(waypoint2);
                    other.GetComponent<PedestrianController>().setMovementSpeed(Random.Range(1.4f, 1.5f));
                    break;
                case 3:
                    other.GetComponent<WaypointPedestrianNavigator>().setCurrentWaypoint(waypoint3);
                    other.GetComponent<PedestrianController>().setMovementSpeed(Random.Range(1.4f, 1.5f));
                    break;
                case 4:
                    break;
            }
        }
    }
}

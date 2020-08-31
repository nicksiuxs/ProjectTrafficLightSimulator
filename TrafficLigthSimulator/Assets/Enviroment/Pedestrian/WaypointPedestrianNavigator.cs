using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPedestrianNavigator : MonoBehaviour
{
    PedestrianController controller;
    public Waypoint currentWaypoint;
    float direction;

    private void Awake()
    {
        controller = GetComponent<PedestrianController>();
    }
    void Start()
    {
        controller.SetDestination(currentWaypoint.GetPosition());
        direction = Mathf.RoundToInt(UnityEngine.Random.Range(0, 1));
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.reachedDestination)
        {
            if (direction == 0)
            {
                currentWaypoint = currentWaypoint.nextWaypoint;
            }
            else if (direction == 1)
            {
                currentWaypoint = currentWaypoint.previousWaypoint;
            }
            controller.SetDestination(currentWaypoint.GetPosition());
        }
    }

    public void setCurrentWaypoint(Waypoint waypoint)
    {
        currentWaypoint = waypoint;
    }
}

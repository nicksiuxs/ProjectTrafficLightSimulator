using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianSpawner : MonoBehaviour
{
    // Spawn points objects
    public GameObject s1, s2, s3, s4;

    //Pedestrian prefabs
    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;

    //Waypoints to spwan 
    public Waypoint w1, w2, w3, w4;

    public float spawnRate;
    float nextSpawn;
    int totalPedestrian = 0;
    int whatToSpawn;
    public int maxPedestrian;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && totalPedestrian <= maxPedestrian)
        {
            whatToSpawn = Random.Range(1, 5);
            Debug.Log(whatToSpawn + "punto spawn");

            if (whatToSpawn == 1)
            {
                randomCharacter(s1, w1);
                Debug.Log(s1, w1);
            }
            if (whatToSpawn == 2)
            {
                randomCharacter(s2, w2);
            }
            if (whatToSpawn == 3)
            {
                randomCharacter(s3, w3);
            }
            if (whatToSpawn == 4)
            {
                randomCharacter(s4, w4);
            }
            nextSpawn = Time.time + spawnRate;
        }
    }

    public void spawnPedestrian(GameObject pedestrian, Waypoint waypoint, GameObject spawn)
    {
        pedestrian.GetComponent<WaypointPedestrianNavigator>().setCurrentWaypoint(waypoint);
        Instantiate(pedestrian, spawn.transform.position, spawn.transform.rotation);

        totalPedestrian++;
    }

    void randomCharacter(GameObject spawn, Waypoint waypoint)
    {
        int random = Random.Range(1, 11);
        switch (random)
        {
            case 1:
                spawnPedestrian(p1, waypoint, spawn);
                break;
            case 2:
                spawnPedestrian(p2, waypoint, spawn);
                break;
            case 3:
                spawnPedestrian(p3, waypoint, spawn);
                break;
            case 4:
                spawnPedestrian(p4, waypoint, spawn);
                break;
            case 5:
                spawnPedestrian(p5, waypoint, spawn);
                break;
            case 6:
                spawnPedestrian(p6, waypoint, spawn);
                break;
            case 7:
                spawnPedestrian(p7, waypoint, spawn);
                break;
            case 8:
                spawnPedestrian(p8, waypoint, spawn);
                break;
            case 9:
                spawnPedestrian(p9, waypoint, spawn);
                break;
            case 10:
                spawnPedestrian(p10, waypoint, spawn);
                break;
            case 11:
                break;
        }

    }
}

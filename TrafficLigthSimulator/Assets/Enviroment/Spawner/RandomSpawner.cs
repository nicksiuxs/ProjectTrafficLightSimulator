using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject car1, car2, car3, car4;
    public Waypoint waypoint1, waypoint2;
    
    public float spawnRate = 2f;
    public float height = 0.0340f;

    float nextSpawn = 0f;

    int whatToSpawn;
    int totalCars = 0;
    public int maxCars;

    void Update()
    {

        if (Time.time > nextSpawn && totalCars <= maxCars)
        {
            whatToSpawn = Random.Range(1, 5);
            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(car1, new Vector3(transform.position.x, height, transform.position.z), transform.rotation);
                    car1.GetComponent<WaypointNavigator>().currentWaypoint = RandomWaypoint();
                    totalCars++;
                    break;
                case 2:
                    Instantiate(car2, new Vector3(transform.position.x, height, transform.position.z), transform.rotation);
                    car2.GetComponent<WaypointNavigator>().currentWaypoint = RandomWaypoint();
                    totalCars++;
                    break;
                case 3:
                    Instantiate(car3, new Vector3(transform.position.x, height, transform.position.z), transform.rotation);
                    car3.GetComponent<WaypointNavigator>().currentWaypoint = RandomWaypoint();
                    totalCars++;
                    break;
                case 4:
                    Instantiate(car4, new Vector3(transform.position.x, height, transform.position.z), transform.rotation);
                    car4.GetComponent<WaypointNavigator>().currentWaypoint = RandomWaypoint();
                    totalCars++;
                    break;
                case 5:
                    break;
            }

            nextSpawn = Time.time + spawnRate;
        }
    }

    Waypoint RandomWaypoint()
    {
        int random = Random.Range(1, 3);
        Debug.Log(random);

        return (random == 1) ? waypoint1 : waypoint2;
    }
}

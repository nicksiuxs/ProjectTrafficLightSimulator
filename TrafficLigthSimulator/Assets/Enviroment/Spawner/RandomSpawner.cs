using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12;
    public Waypoint waypoint1, waypoint2;

    public float spawnRate = 2f;
    public float height, h1, h2, h3, h4;

    float nextSpawn = 0f;

    int whatToSpawn;
    int totalCars = 0;
    public int maxCars;

    void Update()
    {

        if (Time.time > nextSpawn && totalCars <= maxCars)
        {
            whatToSpawn = Random.Range(1, 13);
            switch (whatToSpawn)
            {
                case 1:
                    spawnCar(car1, h1);
                    break;
                case 2:
                    spawnCar(car2, h1);
                    break;
                case 3:
                    spawnCar(car3, h1);
                    break;
                case 4:
                    spawnCar(car4, h2);
                    break;
                case 5:
                    spawnCar(car5, h2);
                    break;
                case 6:
                    spawnCar(car6, h2);
                    break;
                case 7:
                    spawnCar(car7, h3);
                    break;
                case 8:
                    spawnCar(car8, h3);
                    break;
                case 9:
                    spawnCar(car9, h3);
                    break;
                case 10:
                    spawnCar(car10, h4);
                    break;
                case 11:
                    spawnCar(car11, h4);
                    break;
                case 12:
                    spawnCar(car12, h4);
                    break;
                case 13:
                    Debug.Log("13");
                    break;
            }

            nextSpawn = Time.time + spawnRate;
        }
    }

    Waypoint RandomWaypoint()
    {
        int random = Random.Range(1, 3);
        Debug.Log("Waypoint" + random);

        return (random == 1) ? waypoint1 : waypoint2;
    }

    public void spawnCar(GameObject car, float h)
    {
        car.GetComponent<WaypointNavigator>().currentWaypoint = RandomWaypoint();
        Instantiate(car, new Vector3(transform.position.x, h, transform.position.z), transform.rotation);

        totalCars++;
    }
}

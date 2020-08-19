using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(0f);
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(0f);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            other.GetComponent<CharacterNavigationController>().setMovementSpeed(10f);
        }

    }
}

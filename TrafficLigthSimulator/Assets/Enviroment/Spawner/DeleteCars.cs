using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCars : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) {
       if(other.gameObject.CompareTag("Car") || other.gameObject.CompareTag("Pedestrian"))
       {
           Destroy(other);
       }
   }
}

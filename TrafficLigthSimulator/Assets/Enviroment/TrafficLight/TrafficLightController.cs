using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    public GameObject red;
    public GameObject yellow;
    public GameObject green;

    public GameObject zoneReducer;

    public bool isActive;
    public float durationRed;
    public float durationYellow;
    public float durationGreen;

    public bool isRed;
    public bool isYellow;
    public bool isGreen;
    public bool reverse;

    void Start()
    {
        isRed = true;
        reverse = false;
        StartCoroutine("changeLight");
    }

    void Update()
    {

    }

    public IEnumerator changeLight()
    {
        while (true)
        {
            if (isRed)
            {
                red.SetActive(true);
                yellow.SetActive(false);
                green.SetActive(false);
                yield return new WaitForSeconds(durationRed);
                isRed = false;
                isYellow = true;
            }

            if (isYellow)
            {

                red.SetActive(false);
                yellow.SetActive(true);
                green.SetActive(false);
                yield return new WaitForSeconds(durationYellow);
                isYellow = false;
                if (!reverse)
                {
                    isGreen = true;
                }
                else
                {
                    isRed = true;
                    reverse = false;
                }

            }
            if (isGreen)
            {

                red.SetActive(false);
                yellow.SetActive(false);
                green.SetActive(true);
                yield return new WaitForSeconds(durationGreen);
                isGreen = false;
                if (isRed == false && isYellow == false)
                {
                    isYellow = true;
                    reverse = true;
                }

            }

        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    public GameObject red;
    public GameObject yellow;
    public GameObject green;

    public bool isActive = false;

    public float durationRed;
    public float durationYellow;
    public float durationGreen;

    public bool isRed;
    public bool isYellow;
    public bool isGreen;
    public bool reverse;

    public float timeInseconds;

    void Start()
    {
        isRed = true;
        reverse = false;
    }

    void Update()
    {
        timeInseconds += Time.deltaTime;

        if (isRed && (timeInseconds > durationRed))
        {
            timeInseconds = 0f;
            if (isActive)
            {
                isRed = false;
                red.SetActive(false);

                isYellow = true;
                yellow.SetActive(true);
            }
        }

        if (isYellow && (timeInseconds > durationYellow))
        {
            timeInseconds = 0f;

            isYellow = false;
            yellow.SetActive(false);

            if (!reverse)
            {
                isGreen = true;
                green.SetActive(true);
            }

            else
            {
                reverse = false;

                isRed = true;
                red.SetActive(true);

                //Pendiente de is active
                isActive = false;
            }


        }
        if (isGreen && (timeInseconds > durationGreen))
        {
            timeInseconds = 0f;

            green.SetActive(false);
            isGreen = false;

            reverse = true;

            isYellow = true;
            yellow.SetActive(true);

        }
    }

    public void setIsActive(bool isActive)
    {
        this.isActive = isActive;
    }

    public bool getIsActive()
    {
        return this.isActive;
    }

}
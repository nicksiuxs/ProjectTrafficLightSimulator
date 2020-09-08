﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightTIntersectionController : MonoBehaviour
{
    public TrafficLightController trafficLight1;
    public TrafficLightController trafficLight2;
    public TrafficLightController trafficLight3;
    bool tl1 = false;
    bool tl2 = false;
    bool tl3 = false;

    // Esto es para las pruebas, los podes borrar
    public bool prueba1 = false;
    public bool prueba2 = false;
    public bool prueba3 = false;

    public float secondsGreen;

    void Start()
    {
        // tl1 = true;
    }

    void Update()
    {
        if (!trafficLight1.getIsActive() && tl1)
        {
            // trafficLight2.setIsActive(true);
            tl1 = false;
            // tl2 = true;
        }

        if (!trafficLight2.getIsActive() && tl2)
        {
            // trafficLight3.setIsActive(true);
            tl2 = false;
            // tl3 = true;
        }

        if (!trafficLight2.getIsActive() && !trafficLight3.getIsActive() && !trafficLight1.getIsActive() && tl3)
        {
            // trafficLight1.setIsActive(true);
            // tl1 = true;
        }

        // De aqui para abajo tambien se puede borrar
        if (prueba1)
        {
            setActiveTrafficLight1(true, secondsGreen);
        }
        else if (prueba2)
        {
            setActiveTrafficLight2(true, secondsGreen);
        }
        else if (prueba3)
        {
            setActiveTrafficLight3(true, secondsGreen);
        }
    }

    public void setActiveTrafficLight1(bool isActive, float timeGreen)
    {
        if (isActive)
        {
            tl1 = true;
            trafficLight1.setIsActive(true);
            trafficLight1.setDurationGreen(timeGreen);
            tl2 = false;
            tl3 = false;
        }

        else
        {
            tl1 = false;
        }

    }

    public void setActiveTrafficLight2(bool isActive, float timeGreen)
    {
        if (isActive)
        {
            tl2 = true;
            trafficLight2.setIsActive(true);
            trafficLight2.setDurationGreen(timeGreen);
            tl1 = false;
            tl3 = false;
        }

        else
        {
            tl2 = false;
        }

    }

    public void setActiveTrafficLight3(bool isActive, float timeGreen)
    {
        if (isActive)
        {
            tl3 = true;
            trafficLight3.setIsActive(true);
            trafficLight3.setDurationGreen(timeGreen);
            tl2 = false;
            tl1 = false;
        }

        else
        {
            tl3 = false;
        }

    }
}

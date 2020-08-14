using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightTIntersectionController : MonoBehaviour
{
    public TrafficLightController trafficLight1;
    public TrafficLightController trafficLight2;
    public TrafficLightController trafficLight3;
    bool tl1;
    bool tl2;
    bool tl3;

    void Start()
    {
        tl1 = true;
    }

    void Update()
    {
        if (!trafficLight1.getIsActive() && tl1)
        {
            trafficLight2.setIsActive(true);
            tl1 = false;
            tl2 = true;
        }

        if (!trafficLight2.getIsActive() && tl2)
        {
            trafficLight3.setIsActive(true);
            tl2 = false;
            tl3 = true;
        }

        if (!trafficLight2.getIsActive() && !trafficLight3.getIsActive() && !trafficLight1.getIsActive() && tl3)
        {
            trafficLight1.setIsActive(true);
            tl1 = true;
        }
    }
}

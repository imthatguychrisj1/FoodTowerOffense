using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject waypointContainer;
    public float speed = 3f;
    public float minimumDistance = 3f;

    private Transform[] waypoints;
    private int currentWaypoint;

    void Start()
    {
        Transform[] potentialWaypoints = waypointContainer.GetComponentsInChildren<Transform>();
        waypoints = new Transform[potentialWaypoints.Length - 1];

        for (int i = 1; i < potentialWaypoints.Length; ++i)
        {
            waypoints[i - 1] = potentialWaypoints[i];
        }
    }

    void Update()
    {
        if ((transform.position - waypoints[currentWaypoint].position).magnitude < minimumDistance)
        {
            currentWaypoint += 1;
            if (currentWaypoint == waypoints.Length)
            {
                currentWaypoint = 0;
            }
        }
    }
}

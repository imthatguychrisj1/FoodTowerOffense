using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float waypointProximity = 25f;
    public Transform waypointContainer;
    public float speed = 3f;
    public float minimumDistance = 3f;

    private Transform[] waypoints;
    private int currentWaypoint = 0;

    void Start()
    {
        GetWaypoints();
    }

    void FixedUpdate()
    {
        Vector3 relativeWaypointPosition = transform.InverseTransformPoint(new Vector3(waypoints[currentWaypoint].position.x,
        transform.position.y, waypoints[currentWaypoint].position.z));

        Vector3 localVelocity = transform.InverseTransformDirection(GetComponent<Rigidbody>().velocity);

        if (relativeWaypointPosition.magnitude < waypointProximity)
        {
            currentWaypoint += 1;
            if (currentWaypoint == waypoints.Length)
            {
                currentWaypoint = 0;
            }
        }
    }

    private void GetWaypoints()
    {
        Transform[] potentialWaypoints = waypointContainer.GetComponentsInChildren<Transform>();
        waypoints = new Transform[potentialWaypoints.Length - 1];

        for (int i = 1; i < potentialWaypoints.Length; ++i)
        {
            waypoints[i - 1] = potentialWaypoints[i];
        }
    }

    public Transform GetCurrentWaypoint()
    {
        return waypoints[currentWaypoint];
    }

    public Transform GetLastWaypoint()
    {
        if (currentWaypoint - 1 < 0)
        {
            return waypoints[waypoints.Length - 1];
        }

        return waypoints[currentWaypoint - 1];
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine.AI;

public class WayPoints : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject[] waypoints;
    int currentPoint = 0;
    int numOfPoint;
    Transform target;
    public float velocity = 5; 

    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        numOfPoint = waypoints.Length;
        target = waypoints[currentPoint].transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * velocity * Time.deltaTime);
    }
}

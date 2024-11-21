using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving2 : MonoBehaviour
{
    private Vector2 pointA = new Vector2(-5f, 8f);
    private Vector2 pointB = new Vector2(5f, 8f);
    public float speed = 5f;

    private Vector2 targetPoint; 
   void Start()
    {
        transform.position = new Vector3(pointA.x, pointA.y, -1);
        targetPoint = pointB;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, targetPoint) < 0.1f)
        { targetPoint = targetPoint == pointA ? pointB : pointA; 
        }
    }
}
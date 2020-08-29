﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed = 120;
    public float stopDistance = 2f;
    public Vector3 destination;
    public Animator animator;
    public bool reachedDestination;

    private Vector3 lastPosition;
    public Vector3 velocity;

    private void Awake()
    {
        movementSpeed = Random.Range(1f, 2f);
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(transform.position != destination)
        {
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0;
            float destinationDistance = destinationDirection.magnitude;
            if(destinationDistance >= stopDistance)
            {
                reachedDestination = false;
                Quaternion targetRotation = Quaternion.LookRotation(destinationDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            }
            else{
                reachedDestination = true;
            }

            velocity = (transform.position - lastPosition) / Time.deltaTime;
            velocity.y = 0;
            var velocityMargnitude = velocity.magnitude;
            velocity = velocity.normalized;

            animator.SetFloat("VelX", velocity.x);
            animator.SetFloat("VelY", velocity.z);
        }

        lastPosition = transform.position;
    }
    
    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }
    
    public float getMovementSpeed()
    {
        return this.movementSpeed;
    }

    public void setMovementSpeed(float newSpeed)
    {
        this.movementSpeed = newSpeed;
    }
}
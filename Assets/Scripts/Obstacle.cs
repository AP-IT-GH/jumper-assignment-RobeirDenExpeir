using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 2f;

    private void Update()
    {
        this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wallend") == true)
        {
            Destroy(this.gameObject);
        }
    }
}
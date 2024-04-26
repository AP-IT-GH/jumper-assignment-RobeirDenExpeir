using System;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using UnityEngine;

public class MLAgent : Agent
{
    public float force = 5f;
    public Transform orig = null;
    private Rigidbody rb = null;
    private bool isGrounded;

    public override void Initialize()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        //orig.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    // Migrated function
    public override void OnActionReceived(ActionBuffers actions)
    {
        if (actions.DiscreteActions[0] == 1 && isGrounded)
        {
            Thrust();
        }
    }

    // Migrated version
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var discreteActions = actionsOut.DiscreteActions;
        discreteActions[0] = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            discreteActions[0] = 1;
        }
    }

    public override void OnEpisodeBegin()
    {
        ResetPlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ob") == true)
        {
            AddReward(-1.0f);
            Destroy(collision.gameObject);
            EndEpisode(); 
        }

        if(collision.gameObject.CompareTag("walltop") == true)
        {
            AddReward(-1.0f);
            EndEpisode(); 
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("wallreward") == true)
        {
            AddReward(0.1f);
        }
    }

    private void Thrust()
    {
        // Acceleration
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        isGrounded = false;
    }

    private void ResetPlayer()
    {
        this.transform.position = new Vector3(orig.position.x, orig.position.y, orig.position.z);
    }
}
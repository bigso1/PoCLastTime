using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MovingGroundSpecial : MonoBehaviour
{
    public ConstraintSource mySource;
    // Start is called before the first frame update
    private void Start()
    {
        mySource.sourceTransform = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")) return;
        Debug.Log("player detected");
        other.transform.SetParent(transform);
        
        /*var constrainter = other.GetComponent<PlayerMovementScript>().parenting;
        constrainter.SetSource(0, mySource);
        constrainter.constraintActive = true;*/
        
        
        Debug.Log("Player Constrainted");
    }

    private void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Player")) return;
        other.transform.SetParent(null);
        
        /*var constrainter = other.GetComponent<PlayerMovementScript>().parenting;
        constrainter.RemoveSource(0);
        constrainter.constraintActive = false;*/
        
        
    }
}

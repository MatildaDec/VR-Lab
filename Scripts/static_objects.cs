using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static_objects : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="colb")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.isKinematic=true;
        }
    }
}

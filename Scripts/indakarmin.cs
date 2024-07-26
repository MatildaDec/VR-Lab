using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indakarmin : MonoBehaviour
{
    public GameObject partical_water;
    public GameObject partical_indark;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "water")
        {
            partical_water.SetActive(true);
        }
        if (other.gameObject.tag=="ind")
        {
            partical_water.SetActive(false);
            partical_indark.SetActive(true);
        }
    }
}

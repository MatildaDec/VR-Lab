using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rastvor : MonoBehaviour
{
    public ParticleSystem Water;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "table")
        {
            Water.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.x > 45 || transform.rotation.eulerAngles.x < -45 || transform.rotation.eulerAngles.z > 45 || transform.rotation.eulerAngles.z < -45)
        {
            if(stat.instance.water==3)
            {
                Water.gameObject.SetActive(true);
            }
        }
          


    }
}

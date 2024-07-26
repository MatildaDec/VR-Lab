using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_effects : MonoBehaviour
{
    public ParticleSystem fire;
    
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag=="hand")
        {
           singlton.inst.fire_box_hand = 1;
            fire.gameObject.SetActive(true);
        }
    }

}

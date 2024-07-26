using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colb_fire : MonoBehaviour
{
    public ParticleSystem fire;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="firebox")
        {
            if(singlton.inst.fire_box_hand==1)
            {
                fire.gameObject.SetActive(true);
                if (stat.instance.water == 1)
                {
                    stat.instance.water = 2;
                }
            }
        }
    }
}

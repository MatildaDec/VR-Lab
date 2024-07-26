using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_strike : MonoBehaviour
{
    public GameObject water_rast;
    public GameObject water_part;
    public GameObject water_hot_part;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "water")
        {
            water_part.SetActive(true);

            stat.instance.water = 1;
        }

        if (other.gameObject.tag == "stat")
        {
            if (stat.instance.water == 2)

                StartCoroutine(Wait_water_hot());
            stat.instance.water = 3;
        }
        if(other.gameObject.tag=="rast")
        {
            if(stat.instance.tabletk==1 && stat.instance.water==3)
            {
                water_rast.SetActive(true);
            }
        }
    
    }
    IEnumerator Wait_water_hot()
    {
        yield return new WaitForSeconds(7);
        water_hot_part.SetActive(true);
        yield return null;
    }
}

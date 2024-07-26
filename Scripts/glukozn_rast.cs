using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glukozn_rast : MonoBehaviour
{
    public GameObject partical_final;
    public GameObject partical_indark;
    public GameObject partical_final_colb;
    public GameObject partical_in_colb;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="colb" && stat.instance.tabletk==4 && stat.instance.sum_soda==10)
        {
            stat.instance.soda_rastvor = 1;
        }
        if(other.gameObject.tag=="rast2")
        {
           //  partical_final_colb.SetActive(true);
             partical_final.SetActive(true);
            partical_in_colb.SetActive(false);
            partical_indark.SetActive(false);
            stat.instance.final = 1;
        }   
    }
}

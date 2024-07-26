using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soda : MonoBehaviour
{
    public GameObject soda_effect;
    public int sum_weight=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="colb")
        {
            
            soda_effect.SetActive(true);
            if (stat.instance.cold_on_weight == 1)
            {
                sum_weight += 5;
                stat.instance.sum_soda += 5;
                
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        stat.instance.weght_text.text = sum_weight + "";
    }
}

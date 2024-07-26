using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabletki : MonoBehaviour
{
    public int tablet = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tab")
        {
            tablet += 1;
            if(tablet==4)
            {
                stat.instance.tabletk = 1;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

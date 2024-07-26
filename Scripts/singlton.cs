using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singlton : MonoBehaviour
{
    public static singlton inst;
    public int fire_box_hand = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(inst==null)
        {
            inst = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stat : MonoBehaviour
{
    public static stat instance;
    public Text weght_text;
    public int water = 0;
    public int tabletk = 0;
    public int cold_on_weight;
    public int sum_soda = 0;
    public int soda_rastvor = 0;
    public int final=0;
    public Text text_finish;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null)
        {
            instance = this;

        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(final==1)
        {
            text_finish.text = "Всё выполнено правильно!";
        }
    }
}

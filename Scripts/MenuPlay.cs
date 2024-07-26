using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPlay : MonoBehaviour
{
    public GameObject colb;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayButton(int id)
    {
        Destroy(colb.gameObject);
        SceneManager.LoadSceneAsync(id);
    }
    
}

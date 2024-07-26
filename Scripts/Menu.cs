using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{   
    public GameObject colb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ColbTeleporting()
    {
        Destroy(colb.gameObject);
        SceneManager.LoadSceneAsync(1);
        
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

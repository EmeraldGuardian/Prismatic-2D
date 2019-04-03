using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    public string StartScene;
    public string instructionsScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButon()
    {
        SceneManager.LoadScene(StartScene);
    }


    public void Instructions()
    {
        SceneManager.LoadScene(instructionsScene);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}

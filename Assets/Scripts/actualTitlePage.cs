using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class actualTitlePage : MonoBehaviour
{
    public string SceneSelection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void loadIntro()
    {
        SceneManager.LoadScene(SceneSelection);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            loadIntro();
        }
    }
}



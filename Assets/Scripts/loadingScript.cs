using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingScript : MonoBehaviour
{
    public string scene;
    public int time;
    void Start()
    {
        StartCoroutine(loadScene());
    }

    IEnumerator loadScene()
    {
  
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scene);

    }
}

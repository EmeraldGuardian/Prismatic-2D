using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int index;
    public string levelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //loading level with scene name
            SceneManager.LoadScene(levelName);

            //loading level with index
            SceneManager.LoadScene(index);
        }
    }
}

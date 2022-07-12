using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reloaded");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

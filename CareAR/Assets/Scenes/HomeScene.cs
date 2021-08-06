using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Sketch()
    {
        SceneManager.LoadScene(1);
        Debug.Log("I am in AR Draw scene");
    }

    public void Nav()
    {
        SceneManager.LoadScene(2);
        Debug.Log("I am in AR Draw scene");
    }

    public void ExitApplication()
    {
        Debug.Log("Exiting the Experience...");
        Application.Quit();
    }
}

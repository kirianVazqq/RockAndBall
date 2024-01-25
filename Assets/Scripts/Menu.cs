using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject options;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play() 
    {
        SceneManager.LoadScene("FirstLevel");
    
    }

    public void Level2()
    {
        SceneManager.LoadScene("SecondLevel");

    }

    public void Level3()
    {
        SceneManager.LoadScene("ThirdLevel");

    }

    public void Level4()
    {
        SceneManager.LoadScene("ExtremeLevel");

    }

    public void Exit()
    {
        Application.Quit();
    }
}

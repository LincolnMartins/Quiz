using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject QuizScreen;
    public GameObject FinalScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStart()
    {
        StartScreen.SetActive(false);
        QuizScreen.SetActive(true);
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene(0);
    }
}

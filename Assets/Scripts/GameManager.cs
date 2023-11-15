using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton
    public static GameManager Instance { get; private set; }

    //Telas
    public GameObject StartScreen; // Tela de inicio
    public GameObject QuizScreen; // Tela de perguntas
    public GameObject FinalScreen; // Tela de finaliza��o

    // Banco de Perguntas
    public Question[] questions;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Fun��o chamada quando se clica no bot�o 'Come�ar' na tela de inicio
    public void OnClickStart()
    {
        //Transposi��o da tela de inicio para tela da perguntas
        StartScreen.SetActive(false);
        QuizScreen.SetActive(true);
    }

    // Fun��o chamada quando se clica no bot�o 'Menu' na tela de finaliza��o
    public void OnClickMenu()
    {
        //Reinicia o jogo
        SceneManager.LoadScene(0);
    }
}

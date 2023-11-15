using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{    
    public GameObject[] options; //Alternativas
    public TextMeshProUGUI question; // Quest�o

    private int activeQuestion; //id da quest�o ativa no momento

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        ShowNextQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Mostra a quest�o ativa no momento e todas as alternativas dispon�veis
    void ShowNextQuestion()
    {
        question.text = GameManager.Instance.questions[activeQuestion].Pergunta;
        for (int i = 0; i < options.Length; i++)
            options[i].GetComponentInChildren<TextMeshProUGUI>().text = GameManager.Instance.questions[activeQuestion].Options[i];
        activeQuestion++;
    }
}

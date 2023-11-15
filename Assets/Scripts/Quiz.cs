using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{    
    public GameObject[] options; //Alternativas
    public TextMeshProUGUI question; // Questão

    private int activeQuestion; //id da questão ativa no momento

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

    // Mostra a questão ativa no momento e todas as alternativas disponíveis
    void ShowNextQuestion()
    {
        question.text = GameManager.Instance.questions[activeQuestion].Pergunta;
        for (int i = 0; i < options.Length; i++)
            options[i].GetComponentInChildren<TextMeshProUGUI>().text = GameManager.Instance.questions[activeQuestion].Options[i];
        activeQuestion++;
    }
}

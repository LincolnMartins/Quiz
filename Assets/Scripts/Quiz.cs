using System;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public GameObject[] options; //Alternativas
    public TextMeshProUGUI question; // Questão

    [NonSerialized]
    public int activeQuestion; //id da questão ativa no momento

    //Chamado quando o objeto é ativado na tela
    private void OnEnable()
    {
        // Exibe a questão ativa no momento e todas as alternativas disponíveis
        question.text = GameManager.Instance.questions[activeQuestion].Pergunta;

        for (int i = 0; i < options.Length; i++)
            options[i].GetComponentInChildren<TextMeshProUGUI>().text = GameManager.Instance.questions[activeQuestion].Options[i];
    }
}

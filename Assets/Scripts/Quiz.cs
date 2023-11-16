using System;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public GameObject[] options; //Alternativas
    public TextMeshProUGUI question; // Quest�o

    [NonSerialized]
    public int activeQuestion; //id da quest�o ativa no momento

    //Chamado quando o objeto � ativado na tela
    private void OnEnable()
    {
        // Exibe a quest�o ativa no momento e todas as alternativas dispon�veis
        question.text = GameManager.Instance.questions[activeQuestion].Pergunta;

        for (int i = 0; i < options.Length; i++)
            options[i].GetComponentInChildren<TextMeshProUGUI>().text = GameManager.Instance.questions[activeQuestion].Options[i];
    }
}

using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton
    public static GameManager Instance;

    //Constantes
    public const int MAX_POINTS = 3;

    //Telas
    public GameObject StartScreen; // Tela de inicio
    public GameObject QuizScreen; // Tela de perguntas
    public GameObject ResponseScreen; // Tela de resposta

    // Banco de Perguntas
    public Question[] questions;

    [NonSerialized] public int pontos; //numero de pontos do jogador
    [NonSerialized] public bool sucess; // marca se o jogador acertou a pergunta atual ou n�o


    //Chamado quando o objeto � carregado na cena
    private void Awake()
    {
        Instance = this;
    }

    // Fun��o chamada quando se clica no bot�o 'Come�ar' na tela de inicio
    public void OnClickStart()
    {
        //Transposi��o da tela de inicio para tela da perguntas
        StartScreen.SetActive(false);
        QuizScreen.SetActive(true);
    }
}

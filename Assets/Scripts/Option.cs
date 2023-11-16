using UnityEngine;

public class Option : MonoBehaviour
{
    // Chamado quando jogador clica na opção
    public void OnClickOption()
    {
        var quiz = transform.parent.gameObject.GetComponent<Quiz>();
        for (int i = 0; i < quiz.options.Length; i++)
        {
            if (quiz.options[i] == gameObject)
            {
                //Verifica se jogador acertou a pergunta
                if (GameManager.Instance.questions[quiz.activeQuestion].Resposta == i)
                {
                    GameManager.Instance.pontos++;
                    GameManager.Instance.sucess = true;
                }
                else GameManager.Instance.sucess = false;

                //Transposição da tela de perguntas para tela de resposta
                GameManager.Instance.QuizScreen.SetActive(false);
                GameManager.Instance.ResponseScreen.SetActive(true);
                break;
            }
        }
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Response : MonoBehaviour
{
    //Buttons
    public GameObject menuButton;
    public GameObject continueButton;

    //Texto da resposta
    public TextMeshProUGUI answer;

    //Chamado quando o objeto é ativado na tela
    private void OnEnable()
    {
        //Verifica se o jogador acertou ou errou a pergunta
        if (GameManager.Instance.sucess)
        {
            //Verifica se o jogador venceu
            if (GameManager.Instance.pontos >= 3)
            {
                answer.text = $"Você Venceu!\nParabéns!";
                continueButton.SetActive(false);
                menuButton.SetActive(true);
            }
            else
            {
                answer.text = $"Você Acertou!\nPrepare-se para a próxima pergunta";
                continueButton.SetActive(true);
            }
        }
        else
        {
            var activequestion = GameManager.Instance.QuizScreen.GetComponent<Quiz>().activeQuestion;
            answer.text = $"Você Errou!\nDica: {GameManager.Instance.questions[activequestion].Dica}";
            continueButton.SetActive(false);
            menuButton.SetActive(true);
        }
    }

    // Função chamada quando se clica no botão 'Menu'
    public void OnClickMenu()
    {
        //Reinicia o jogo
        SceneManager.LoadScene(0);
    }

    // Função chamada quando se clica no botão 'Continuar'
    public void OnClickContinue()
    {
        // Passa para próxima questão
        GameManager.Instance.QuizScreen.GetComponent<Quiz>().activeQuestion++;
        GameManager.Instance.ResponseScreen.SetActive(false);
        GameManager.Instance.QuizScreen.SetActive(true);
    }
}

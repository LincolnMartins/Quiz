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

    //Chamado quando o objeto � ativado na tela
    private void OnEnable()
    {
        //Verifica se o jogador acertou ou errou a pergunta
        if (GameManager.Instance.sucess)
        {
            //Verifica se o jogador venceu
            if (GameManager.Instance.pontos >= 3)
            {
                answer.text = $"Voc� Venceu!\nParab�ns!";
                continueButton.SetActive(false);
                menuButton.SetActive(true);
            }
            else
            {
                answer.text = $"Voc� Acertou!\nPrepare-se para a pr�xima pergunta";
                continueButton.SetActive(true);
            }
        }
        else
        {
            var activequestion = GameManager.Instance.QuizScreen.GetComponent<Quiz>().activeQuestion;
            answer.text = $"Voc� Errou!\nDica: {GameManager.Instance.questions[activequestion].Dica}";
            continueButton.SetActive(false);
            menuButton.SetActive(true);
        }
    }

    // Fun��o chamada quando se clica no bot�o 'Menu'
    public void OnClickMenu()
    {
        //Reinicia o jogo
        SceneManager.LoadScene(0);
    }

    // Fun��o chamada quando se clica no bot�o 'Continuar'
    public void OnClickContinue()
    {
        // Passa para pr�xima quest�o
        GameManager.Instance.QuizScreen.GetComponent<Quiz>().activeQuestion++;
        GameManager.Instance.ResponseScreen.SetActive(false);
        GameManager.Instance.QuizScreen.SetActive(true);
    }
}

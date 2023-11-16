using TMPro;
using UnityEngine;

public class Attempts : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<TextMeshProUGUI>().text = $"{GameManager.Instance.pontos}/{GameManager.MAX_POINTS}";
    }
}

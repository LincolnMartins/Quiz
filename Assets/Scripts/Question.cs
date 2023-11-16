
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Question : ScriptableObject
{
    public string Pergunta;
    public List<string> Options;
    public int Resposta;
    public string Dica;
}

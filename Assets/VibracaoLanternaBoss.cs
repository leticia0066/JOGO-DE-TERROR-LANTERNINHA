using UnityEngine;

public class VibracaoLanternaBoss : MonoBehaviour
{
    public Transform lanterna;
    public Transform boss;
    public float distanciaAtivacao = 4f;
    public float intensidade = 0.15f;

    private Vector3 escalaOriginal;

    void Start()
    {
        escalaOriginal = lanterna.localScale;
    }

    void Update()
    {
        float distancia = Vector2.Distance(lanterna.position, boss.position);

        if (distancia <= distanciaAtivacao)
        {
            float vibrar = Random.Range(-intensidade, intensidade);
            lanterna.localScale = escalaOriginal + new Vector3(vibrar, vibrar, 0);
        }
        else
        {
            lanterna.localScale = escalaOriginal;
        }
    }
}

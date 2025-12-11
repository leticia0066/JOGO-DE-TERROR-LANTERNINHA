using UnityEngine;

public class TremorLanterna : MonoBehaviour
{
    public bool tremer = false;
    public float intensidade = 0.1f;
    public float velocidade = 20f;

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.localPosition;
    }

    void Update()
    {
        if (tremer)
        {
            float x = Mathf.Sin(Time.time * velocidade) * intensidade;
            float y = Mathf.Cos(Time.time * velocidade) * intensidade;

            transform.localPosition = posicaoInicial + new Vector3(x, y, 0);
        }
        else
        {
            transform.localPosition = posicaoInicial;
        }
    }

    public void AtivarTremor(bool estado)
    {
        tremer = estado;
    }
}

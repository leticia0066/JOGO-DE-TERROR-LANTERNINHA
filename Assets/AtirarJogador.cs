using UnityEngine;

public class AtirarJogador : MonoBehaviour
{
    public GameObject prefabTiro;
    public Transform pontoDisparo;

    private PlayerMovimento movimentoPlayer;

    void Start()
    {
        movimentoPlayer = GetComponent<PlayerMovimento>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Atirar();
        }
    }

    void Atirar()
    {
        if (prefabTiro == null || pontoDisparo == null)
        {
            Debug.LogError("PrefabTiro ou PontoDisparo NAO estao atribuidos!");
            return;
        }

        GameObject tiro = Instantiate(prefabTiro, pontoDisparo.position, Quaternion.identity);

        Tiro scriptTiro = tiro.GetComponent<Tiro>();

        if (scriptTiro != null)
            scriptTiro.DefinirDirecao(movimentoPlayer.EstaOlhandoDireita());
        else
            Debug.LogError("O prefab do tiro NAO tem o script Tiro!");
    }
}

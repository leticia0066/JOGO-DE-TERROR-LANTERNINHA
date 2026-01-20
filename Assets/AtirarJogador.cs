using UnityEngine;

public class AtirarJogador : MonoBehaviour
{
    public GameObject prefabTiro;
    public Transform pontoDeDisparo;

    void Update()
    {
        // Atira quando apertar a tecla M
        if (Input.GetKeyDown(KeyCode.M))
        {
            Atirar();
        }
    }

    void Atirar()
    {
        GameObject tiro = Instantiate(prefabTiro, pontoDeDisparo.position, Quaternion.identity);

        // Direção do tiro conforme lado do player
        Tiro scriptTiro = tiro.GetComponent<Tiro>();

        if (transform.localScale.x >= 0)
            scriptTiro.direcao = Vector2.right;
        else
            scriptTiro.direcao = Vector2.left;
    }
}

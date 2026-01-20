using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velocidade = 10f;
    public int dano = 1;
    public Vector2 direcao = Vector2.right;

    void Update()
    {
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("Inimigo"))
        {
            VidaInimigo inimigo = colisao.GetComponent<VidaInimigo>();
            if (inimigo != null)
            {
                inimigo.ReceberDano(dano);
            }

            Destroy(gameObject); // destrói o tiro
        }
    }
}

using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velocidade = 10f;
    private int direcao = 1;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(direcao * velocidade, 0);

        Destroy(gameObject, 2f);
    }

    public void DefinirDirecao(bool olhandoDireita)
    {
        direcao = olhandoDireita ? 1 : -1;

        Vector3 escala = transform.localScale;
        escala.x = Mathf.Abs(escala.x) * direcao;
        transform.localScale = escala;
    }
}

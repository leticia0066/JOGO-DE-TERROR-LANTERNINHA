using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 10f;
    public Transform verificadorChao;
    public LayerMask layerChao;

    private Rigidbody2D rb;
    private bool olhandoDireita = true;
    private bool estaNoChao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);

        // Verificar chao
        estaNoChao = Physics2D.OverlapCircle(verificadorChao.position, 0.2f, layerChao);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space))
{
    Debug.Log("APERTEI ESPACO");
}

        // Virar personagem
        if (movimento > 0 && !olhandoDireita)
            Virar();
        else if (movimento < 0 && olhandoDireita)
            Virar();
    }

    void Virar()
    {
        olhandoDireita = !olhandoDireita;

        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    public bool EstaOlhandoDireita()
    {
        return olhandoDireita;
    }
}

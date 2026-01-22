using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 10f;

    public Transform verificadorChao;
    public LayerMask layerChao;

    private Rigidbody2D rb;
    private bool estaNoChao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimento horizontal
        float movimento = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);

        // Verifica se está no chão
        estaNoChao = Physics2D.OverlapCircle(verificadorChao.position, 0.2f, layerChao);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
        }
    }
}

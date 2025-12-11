using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 7f;

    private Rigidbody2D rb;
    private bool noChao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");

        // Move o player horizontalmente
        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);

        // Pula se estiver no chão e apertar espaço
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.collider.CompareTag("Chao"))
            noChao = true;
    }

    private void OnCollisionExit2D(Collision2D colisao)
    {
        if (colisao.collider.CompareTag("Chao"))
            noChao = false;
    }
}

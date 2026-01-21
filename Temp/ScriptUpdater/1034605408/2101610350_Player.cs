using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    public float velocidade = 5f;

    private Rigidbody2D rb;
    private float movimento;
    private bool olhandoDireita = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimento = Input.GetAxisRaw("Horizontal");

        // Verifica se precisa virar o personagem
        if (movimento > 0 && !olhandoDireita)
            Virar();
        else if (movimento < 0 && olhandoDireita)
            Virar();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);
    }

    void Virar()
    {
        olhandoDireita = !olhandoDireita;

        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    // Informação para outros scripts (ex: tiro)
    public bool EstaOlhandoDireita()
    {
        return olhandoDireita;
    }
}

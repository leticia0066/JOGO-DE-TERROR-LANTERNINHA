using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade = 5f;
    public float forcaPulo = 7f;

    [Header("Sons")]
    public AudioClip somPulo;
    public AudioClip somPasso;

    [Header("Referências")]
    public Transform corpo; // A sprite do corpo que vai virar

    [Header("Lanterna")]
    public bool temLanterna = false; // ← NOVO

    private Rigidbody2D rb;
    private bool noChao = true;
    private AudioSource audioSource;
    private bool tocandoPassos = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        Movimentar(horizontal);
        Pular();
        Virar(horizontal);
        SonsDePassos(horizontal);
    }

    void Movimentar(float h)
    {
        rb.linearVelocity = new Vector2(h * velocidade, rb.linearVelocity.y);
    }

    void Pular()
    {
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
            noChao = false;
            audioSource.PlayOneShot(somPulo);
        }
    }

    void Virar(float h)
    {
        if (h > 0)
            corpo.localScale = new Vector3(1, 1, 1);
        else if (h < 0)
            corpo.localScale = new Vector3(-1, 1, 1);
    }

    void SonsDePassos(float h)
    {
        if (Mathf.Abs(h) > 0.1f && noChao)
        {
            if (!tocandoPassos)
            {
                audioSource.loop = true;
                audioSource.clip = somPasso;
                audioSource.Play();
                tocandoPassos = true;
            }
        }
        else
        {
            if (tocandoPassos)
            {
                audioSource.Stop();
                tocandoPassos = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Chao"))
            noChao = true;
    }

    // 🔦 COLETA DA LANTERNA (NOVO)
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Lanterna"))
        {
            temLanterna = true;

            Destroy(other.gameObject); // remove a lanterna da cena

            Debug.Log("Lanterna coletada!");
        }
    }
}

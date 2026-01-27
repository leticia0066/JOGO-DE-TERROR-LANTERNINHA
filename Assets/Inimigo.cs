using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int vida = 3;
    public float distanciaDeteccao = 3f;
    public AudioClip somProximo;
    private AudioSource audioSource;
    private Transform player;
    private bool somTocado = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        float distancia = Vector2.Distance(transform.position, player.position);

        if (distancia <= distanciaDeteccao && !somTocado)
        {
            audioSource.PlayOneShot(somProximo);
            somTocado = true;
        }
        else if (distancia > distanciaDeteccao)
        {
            somTocado = false;
        }
    }

    public void ReceberDano(int dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            Morrer();
        }
    }

    void Morrer()
    {
        Destroy(gameObject);
    }
}

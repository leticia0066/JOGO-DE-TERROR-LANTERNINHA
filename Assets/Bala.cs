using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidade = 10f;
    public int dano = 1;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity =
            transform.right * velocidade;

        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo") || other.CompareTag("Boss"))
        {
            other.GetComponent<Vida>().LevarDano(dano);
            Destroy(gameObject);
        }
    }
}

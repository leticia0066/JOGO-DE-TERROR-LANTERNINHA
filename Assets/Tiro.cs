using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velocidade = 10f;

    void Update()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo") || other.CompareTag("Boss"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.CompareTag("Chao"))
        {
            Destroy(gameObject);
        }
    }
}

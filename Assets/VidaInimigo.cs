using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public int vida = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tiro"))
        {
            vida--;

            Destroy(other.gameObject);

            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

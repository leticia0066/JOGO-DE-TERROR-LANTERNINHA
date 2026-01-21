using UnityEngine;

public class VidaBoss : MonoBehaviour
{
    public int vida = 10;

   void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("Colidiu com: " + other.name);

    if (other.CompareTag("Tiro"))
    {
        vida--;
        Debug.Log("Vida restante: " + vida);

        Destroy(other.gameObject);

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
}
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida = 3;
    public AudioSource somHit;

    public void LevarDano(int dano)
    {
        vida -= dano;
        somHit.Play();

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}

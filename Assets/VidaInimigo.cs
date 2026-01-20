using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public int vida = 3;

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

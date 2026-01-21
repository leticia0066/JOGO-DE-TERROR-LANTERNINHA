using UnityEngine;

public class AtaqueBoss : MonoBehaviour
{
    public GameObject prefabTiroBoss;
    public float tempoEntreTiros = 2f;
    private float contador;

    void Update()
    {
        contador += Time.deltaTime;

        if (contador >= tempoEntreTiros)
        {
            Atirar();
            contador = 0f;
        }
    }

    void Atirar()
    {
        Instantiate(prefabTiroBoss, transform.position, Quaternion.identity);
    }
}

using UnityEngine;

public class TiroBoss : MonoBehaviour
{
    public float velocidade = 5f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("TiroBoss está sem Rigidbody2D!");
            return;
        }

        rb.linearVelocity = transform.right * velocidade;
        Destroy(gameObject, 3f);
    }
}

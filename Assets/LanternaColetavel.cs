using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LanternaColetavel : MonoBehaviour
{
    public float aumentoLuz = 0.3f;
    public AudioClip somColeta;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Light2D luz = other.GetComponentInChildren<Light2D>();
            luz.intensity += aumentoLuz;

            AudioSource.PlayClipAtPoint(somColeta, transform.position);
            Destroy(gameObject);
        }
    }
}

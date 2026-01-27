using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform pontoTiro;
    public AudioSource somTiro;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(balaPrefab, pontoTiro.position, pontoTiro.rotation);
            somTiro.Play();
        }
    }
}

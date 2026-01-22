using UnityEngine;

public class AtirarJogador : MonoBehaviour
{
    public GameObject prefabTiro;
    public Transform pontoDisparo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(prefabTiro, pontoDisparo.position, Quaternion.identity);
        }
    }
}

using UnityEngine;

public class CameraSeguidora : MonoBehaviour
{
    public Transform jogador;  // Transform do Player para seguir

    public Vector3 deslocamento = new Vector3(0, 1, -10);

    void LateUpdate()
    {
        if (jogador == null)
            return;

        transform.position = jogador.position + deslocamento;
    }
}

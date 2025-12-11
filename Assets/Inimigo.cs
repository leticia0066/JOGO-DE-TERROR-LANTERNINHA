using UnityEngine;

public class DetectorDeProximidade : MonoBehaviour
{
    public Transform player;        // Arraste o Player aqui
    public float distanciaAviso = 3f;  // Distância em que a lanterna começa a tremer

    public TremorLanterna tremorLanterna; // Referência ao script da lanterna

    void Update()
    {
        if (player == null || tremorLanterna == null)
            return;

        // Calcula a distância até o player
        float distancia = Vector2.Distance(transform.position, player.position);

        // Se o player está dentro da zona de aviso → faz a lanterna tremer
        if (distancia <= distanciaAviso)
        {
            tremorLanterna.AtivarTremor(true);
        }
        else
        {
            tremorLanterna.AtivarTremor(false);
        }
    }
}

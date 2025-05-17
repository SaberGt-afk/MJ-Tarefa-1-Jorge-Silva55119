using UnityEngine;

public class MoverEscalar : MonoBehaviour
{
    public float velocidade = 2f;       // Velocidade de movimento no eixo X
    public float escalaAmplitude = 0.5f; // Quanto a escala varia
    public float escalaBase = 1f;        // Tamanho base da escala

    private float tempo;

    void Update()
    {
        tempo += Time.deltaTime;

        // Movimento no eixo X
        transform.position += Vector3.right * velocidade * Time.deltaTime;

        // Oscilação da escala no eixo Y (ou em todos)
        float novaEscala = escalaBase + Mathf.Sin(tempo * velocidade) * escalaAmplitude;
        transform.localScale = new Vector3(novaEscala, novaEscala, novaEscala);
    }
}
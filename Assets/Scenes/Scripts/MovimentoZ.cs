using UnityEngine;

public class MovimentoZ : MonoBehaviour
{
    public float velocidade = 10f;

    void Update()
    {
        transform.Translate(Vector3.back * velocidade * Time.deltaTime, Space.World);
    }
}

using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objetoParaSpawnar;
    public Transform pontoDeSpawn;

    private float tempoParaSpawn = 7f;
    private float cronometro = 0f;

    void Update()
    {
        cronometro += Time.deltaTime;

        if (cronometro >= tempoParaSpawn)
        {
            SpawnarObjeto();
            cronometro = 0f;
        }
    }

    void SpawnarObjeto()
    {
        // Corrige rotação: roda 180° no eixo Y
        Quaternion rotacaoCorrigida = Quaternion.Euler(0f, 180f, 0f);

        GameObject novoObjeto = Instantiate(objetoParaSpawnar, pontoDeSpawn.position, rotacaoCorrigida);
        novoObjeto.AddComponent<MovimentoZ>();
    }
}

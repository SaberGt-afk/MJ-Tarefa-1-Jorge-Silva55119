using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton5 : MonoBehaviour
{
    private Button button;
    private GameManager5 gameManager;
    public int difficulty;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager5>(); 
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " difficulty set!");
        gameManager.StartGame(difficulty);
    }

    void Update()
    {

    }
}

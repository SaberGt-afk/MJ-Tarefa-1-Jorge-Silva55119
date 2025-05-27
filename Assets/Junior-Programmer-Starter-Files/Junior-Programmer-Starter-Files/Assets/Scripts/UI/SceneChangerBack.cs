using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}

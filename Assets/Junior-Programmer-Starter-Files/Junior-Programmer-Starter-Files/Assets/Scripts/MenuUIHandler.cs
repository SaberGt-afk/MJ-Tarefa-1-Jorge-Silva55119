using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;

    public void NewColorSelected(Color color)
    {
        MainManager.Instance.TeamColor = color;
    }

    private void Start()
    {
        ColorPicker.Init();
        ColorPicker.onColorChanged += NewColorSelected;

        // Pre-selecionar a cor guardada ao abrir o menu
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // Guardar a cor antes de sair
        MainManager.Instance.SaveColor();

    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif

        Debug.Log("A fechar o jogo...");
    }

    // ✅ Botão de teste: guardar cor manualmente
    public void SaveColorClicked()
    {
        MainManager.Instance.SaveColor();
        Debug.Log("Cor guardada manualmente.");
    }

    // ✅ Botão de teste: carregar cor manualmente
    public void LoadColorClicked()
    {
        MainManager.Instance.LoadColor();
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);
        Debug.Log("Cor carregada manualmente.");
    }
}

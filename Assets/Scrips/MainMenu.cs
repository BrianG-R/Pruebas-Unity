using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Jugar
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    // Salir
    public void QuitGame()
    {
        Debug.Log("Salir del juego");

        Application.Quit();
    }
}
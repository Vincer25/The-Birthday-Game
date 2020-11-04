using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private static int ChoosenGameLVL;

    public void PlayLevelOne()
    {
        ChoosenGameLVL = 1;
        SceneManager.LoadScene("LevelOne");
    }

    public void PlayLevelTwo()
    {
        ChoosenGameLVL = 2;
        SceneManager.LoadScene("LevelTwo");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(ChoosenGameLVL);
    }
}

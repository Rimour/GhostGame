using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    public void Button_NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Button_QuitGame() 
    { 
        Application.Quit();
    }

}

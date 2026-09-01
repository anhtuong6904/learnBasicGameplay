using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    //load scene
    public void PlayGame()
    {
        Debug.Log("handle button");
        SceneManager.LoadScene("Prototype 2");
    }
    //quit game
    public void QuitGame()
    {
        Debug.Log("handle button");
        Application.Quit();
    }
}

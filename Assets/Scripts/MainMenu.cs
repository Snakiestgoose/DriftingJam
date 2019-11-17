using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Scene List
 * 0 - Menu
 * 1 - Office
 * 2 - Dreams
 * 3 - OfficeArcade
 * 4 - DreamsArcade
 */


public class MainMenu : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void AwakeArcade()
    {
        SceneManager.LoadScene(3);
    }

    public void AsleepArcade()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}

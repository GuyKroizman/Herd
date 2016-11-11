using UnityEngine;


public class ExitButtonScript : MonoBehaviour {

    public void ClickExit()
    {
        Application.Quit();
    }

    public void ClickStart()
    {        
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}

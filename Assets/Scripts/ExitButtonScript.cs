using UnityEngine;
using System.Collections;

public class ExitButtonScript : MonoBehaviour {

    public void ClickExit()
    {
        Application.Quit();
    }

    public void ClickStart()
    {
        Application.LoadLevel("Game");
    }
}

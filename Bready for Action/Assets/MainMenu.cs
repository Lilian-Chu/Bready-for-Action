using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
     public void PlayGame()
     {
        Application.LoadLevelAsync("Tutorial Scene");
     }

     public void QuitGame()
     {
         Debug.Log("QUIT!");
         Application.Quit();
     }
}

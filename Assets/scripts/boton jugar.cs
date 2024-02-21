using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [Tooltip("the (exact) name of the Scene to go play ")]
    [SerializeField] string playLevelName = "";
    [Tooltip("the (exact) name of the Scene to see the instructions ")]
    [SerializeField] string instructionsLevelName = "";
    [Tooltip("the (exact) name of the Scene to see the credits ")]
    [SerializeField] string creditsLevelName = "";
    public void OnClickJugar()
    {
        MMSceneLoadingManager.LoadScene(playLevelName);
    }
    public void OnClickInstrucciones()
    {
        MMSceneLoadingManager.LoadScene(instructionsLevelName);
    }
    public void OnClickCreditos()
    {
        MMSceneLoadingManager.LoadScene(creditsLevelName);
    }
    public void OnClickSalir()
    {
        Application.Quit(); 
    }

}

using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodenivel : MonoBehaviour
{
    public void ONCambiarNivel(string sceneName)
    {
        MMSceneLoadingManager.LoadScene(sceneName);
        //Debug.Log("abrir puerta");
    }
}

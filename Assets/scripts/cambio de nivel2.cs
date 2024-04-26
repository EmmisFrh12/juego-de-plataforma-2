using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodenivel2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ONCambiarNivel2()
    {
        MMSceneLoadingManager.LoadScene("nivel3");
        //Debug.Log("abrir puerta");
    }
}

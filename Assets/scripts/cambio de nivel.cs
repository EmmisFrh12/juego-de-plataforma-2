using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodenivel : MonoBehaviour
{
    // Start is called before the first frame update
    public void ONCambiarNivel()
    {
        MMSceneLoadingManager.LoadScene("nivel2");
        //Debug.Log("abrir puerta");
    }
}

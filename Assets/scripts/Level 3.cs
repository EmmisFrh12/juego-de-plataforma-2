using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    [SerializeField] string level3name = "";

    public void Onnivel3()
    {
        MMSceneLoadingManager.LoadScene(level3name);
    }
}

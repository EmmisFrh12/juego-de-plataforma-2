using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySettings : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    public void OnClickFacil()
    {
        gameManager.MaximumLives = 7;
        gameManager.CurrentLives = 7;
    }
    public void OnClickNormal()
    {
        gameManager.MaximumLives = 5;
        gameManager.CurrentLives = 5;
    }
    public void OnClickDificil()
    {
        gameManager.MaximumLives = 3;
        gameManager.CurrentLives = 3;
    }
    public void OnClickPerma()
    {
        gameManager.MaximumLives = 1;
        gameManager.CurrentLives = 1;
    }

}

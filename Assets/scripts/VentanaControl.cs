using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine;
using System.Linq.Expressions;
using UnityEngine.SceneManagement;

public class VentanaControl : MonoBehaviour
{
    private Vector3 _posicionInicial;
    Vector2 _inicio,_fin;
    [SerializeField]
    GameObject background;
   ///<summary>
   /// Positions of all four side of the screen. It is calculated using the screen camera .
   ///</summary>
 private Vector3
     leftScreenPosition,
     rightScreenPosition,
     topScreenPosition,
     bottomScreenPosition;

    bool isLoaded;

    private RectTransform posicion;
    [SerializeField]
    private GameObject panel;

 
    private void Awake()
    {
        posicion = panel.transform.GetComponent<RectTransform>();
        background.SetActive(true);
        isLoaded = false;
    }
    public void Start()
    {
        _inicio = new Vector3(topScreenPosition.x, topScreenPosition.y + 1500);
        _fin = topScreenPosition;
        posicion.anchoredPosition = _inicio;
        StartCoroutine(AnimarVentana(_inicio, _fin));

        LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
        isLoaded = true;
    }

    public void CerrarVentana()
    {
        
            if (isLoaded)
            {
                _inicio = topScreenPosition;
                _fin = new Vector3(topScreenPosition.x, topScreenPosition.y + 1500);
                posicion.anchoredPosition = _inicio;
                StartCoroutine(AnimarVentana(_inicio, _fin));
                background.SetActive(false);
                isLoaded = false;
            }
        
    }

    IEnumerator AnimarVentana(Vector2 inicio,Vector2 fin){
        MMTween.MoveTransform(this, posicion, inicio, fin, null, 0, 2f, MMTween.MMTweenCurve.EaseInBounce);
        MMTween.MoveRectTransform(this, posicion, inicio, fin, null, 0, 2f, MMTween.MMTweenCurve.EaseInBounce);
        yield return new WaitForSeconds(2f);
       
       
    }
}

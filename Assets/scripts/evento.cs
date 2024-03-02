using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class evento : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    [SerializeField]
    private GameObject door;
    private int monedas_recolectadas;
    // Start is called before the first frame update

    private void Awake()
    {
        if (door == null)
        {
            door = new GameObject();
        }
        
    }
    void Start()
    {
            door.SetActive(false);
    }

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    // Update is called once per frame
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        //Debug.Log(e.PickedItem.name);

        monedas_recolectadas++;
        if (monedas_recolectadas == 4)
        {
            Debug.Log("abrir puerta");
            door.SetActive(true);
        }
    }
}

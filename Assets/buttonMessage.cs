using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class buttonMessage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject tiendaM;
    public string mensaje1 = "";
    //public int valorItem;


    public void Start()
    {
        tiendaM = GameObject.FindGameObjectWithTag("TiendaManager");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        tiendaM.GetComponent<TiendaManager>().escribeTextoMensaje(mensaje1);
        print("El ratón está sobre el botón");
        //tiendaM.GetComponent<TiendaManager>().sumarCarrito(valorItem);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tiendaM.GetComponent<TiendaManager>().borraTextoMensaje();
    }
}

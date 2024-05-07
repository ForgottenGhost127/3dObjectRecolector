using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TiendaManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI infoText;
    public TextMeshProUGUI saldoText;

    public int saldo;

    public int carroCompra;

    void Start()
    {
        //esta variable seria asignada al cargar la escena
        saldo = 3000;
        carroCompra = 0; //el carro empieza valiendo 0.

    }

    public void sumarCarrito(int valor)
    {
        carroCompra += valor;
    }

    public void escribeTextoMensaje(string mensaje)
    {
        infoText.text = mensaje;
    }

    public void borraTextoMensaje()
    {
        infoText.text = "";
    }
}

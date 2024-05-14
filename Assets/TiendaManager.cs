using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TiendaManager : MonoBehaviour
{
    public GameObject datospersist; //script usado para pasar datos entre escenas.

    // Start is called before the first frame update
    public TextMeshProUGUI infoText;
    public TextMeshProUGUI saldoText;
    public TextMeshProUGUI carritoText;
    string tempCarro; //valor temporal del carro

    public GameObject panelConfirma;

    public int saldo;
    public int carro;

    public int carroCompra;

    void Start()
    {
        //esta variable seria asignada al cargar la escena
        saldo = 3000;
        carroCompra = 0; //el carro empieza valiendo 0.
        saldo = datospersist.GetComponent<PersistentData>().saldo;
        saldoText.text = saldo.ToString() + " $";
        panelConfirma.SetActive(false);

    }

    private void Awake()
    {
        datospersist = GameObject.FindGameObjectWithTag("datosPersistentes");
    }
    public void sumarCarrito(int valor)
    {
        

        //solo para poder ver todo, para visualizarlo
        if(carroCompra==0)
        {
            tempCarro = valor.ToString();
        }
        else
        {
            tempCarro = tempCarro + " + " + valor;
        }
        carroCompra += valor;

        carritoText.text = tempCarro.ToString() + " = " + carroCompra + " $";
    }

    public void muestraPanelConfirma()
    {
        panelConfirma.SetActive(true);
    }
    public void ocultaPanelConfirma()
    {
        panelConfirma.SetActive(false);
    }

    public void comprarCarro()
    {
        if (carroCompra <= saldo)
        {
            saldo -= carroCompra;
            saldoText.text = saldo.ToString() + " $";
            vaciarCarro();
            infoText.text = "Compra realizada";

            escribeDatosPersistentes();
        }
        else 
        {
            infoText.text = "No se ha podido realizar la compra, saldo insuficiente";
        }
    }
    public void vaciarCarro()
    {
        carroCompra = 0;
        carritoText.text = "";
        tempCarro= "";
    }

    public void escribeTextoMensaje(string mensaje)
    {
        infoText.text = mensaje;
    }

    public void borraTextoMensaje()
    {
        infoText.text = "";
    }

    public void escribeDatosPersistentes()
    {
        datospersist.GetComponent<PersistentData>().saldo = saldo;
        //algunas variables no hará falta cambiarlas porque conservan el valor de la otra escena
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    public int saldo;
    public float Stamine;
    public Vector3 positionPlayer;

    // Start is called before the first frame update
    void Awake()
    {
        GameObject persistentes = GameObject.FindGameObjectWithTag("datosPersistentes");
        if (persistentes != null && persistentes != gameObject)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

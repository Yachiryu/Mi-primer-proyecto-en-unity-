using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public string mensajeBienvenida;
    public string MiNombre;
    public string Nombrecompañero;
    public int a;
    public int b;
    public bool estaArriba;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo mi nombre es:" + mensajeBienvenida + MiNombre);
        Debug.Log("Mi edad es:" + a);
        Debug.Log("El nombre de mi compañero es:" + Nombrecompañero);
        Debug.Log("Y su edad es:" + b);
        Debug.Log("Y la suma de nuestras edades es:");
        Debug.Log(a + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

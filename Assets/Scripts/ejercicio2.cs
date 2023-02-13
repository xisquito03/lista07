using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    private int i = 1;
    public string n = "Hola, holita, vecinito";
    private void Start()
    {
        while (i <= 20) // Como se necesitan 20 instancias, pues hasta que el i, el cual el valor es 1, llegué a 20, va a seguir sumandose// 
        {
            Debug.Log(n); // En vez de poner un string con la frase directamente en el Log, se hace un string modificable para que se use en diversos casos//
            i++;
        }
    }
}

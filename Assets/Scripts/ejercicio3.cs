using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
    public int i;
    private void Start()
    {
        for (int n = i; n >= 0; n--) // La n es igual a la i, que como es publica, esta se ve modificada en todo momento, y en vez de sumarse, se tiene que hacer una cuenta regresiva, por lo tanto es un --//
        {
            Debug.Log(n);
        }
    }
}

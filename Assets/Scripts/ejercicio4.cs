using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    public int i;
    public int n;

    private void Start()
    {
        while (i <= n)
        {
            if (i % 5 == 0) // Si el resto de la divisi�n da 0, pues entonces se pondr� el Debug en la consola para que solo ense�e los multiplos //
            {
                Debug.Log(i);
            }
            i++; // Se pone este comando fuera para que, indiferententemente de que sea multiplo, o no, se sumar� hasta llegar al int n, siendo este el end // 
        }
    }
}

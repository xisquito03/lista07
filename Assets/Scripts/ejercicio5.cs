using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5 : MonoBehaviour
{
    public int[] numbers;
    private int result;

    private void Start()
    {
        foreach (int num in numbers) // Asi busca cada valor numerico dentro de los numericos, y los aisla de la colección //
        {
            result +=num ;  // El result, es un int que depende solamente de la suma de los 5 numeros del array //


        }
        Debug.Log($"{numbers[0]}+{numbers[1]}+{numbers[2]}+{numbers[3]}+{numbers[4]}={result}"); // En la consola mostrará los 5 numeros, comenzando desde 0, en vez de desde 1, y posteriormente mostrará el result //
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Crear un script que genere 30 GameObjects al inicio
/// </summary>

public class Ejercicio05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject go2 = new GameObject($"Soy {i}");
        }
    }

    
}

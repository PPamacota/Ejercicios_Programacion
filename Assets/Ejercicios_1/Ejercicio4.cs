using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Crear un script que genere una esfera al inicio con un Rigidbody añadido
/// </summary>


public class Ejercicio4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        Rigidbody body = esfera.AddComponent<Rigidbody>();
    }

    
}

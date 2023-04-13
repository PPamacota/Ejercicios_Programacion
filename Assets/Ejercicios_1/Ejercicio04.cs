using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere una esfera al inicio con un Rigidbody a�adido
    /// </summary>
    public class Ejercicio4 : MonoBehaviour
    {
        void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            Rigidbody body = esfera.AddComponent<Rigidbody>();
        }
    }
}
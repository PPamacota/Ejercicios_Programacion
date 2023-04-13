using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere dos esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio6 : MonoBehaviour
    {
        void Start()
        {
            GameObject esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            esfera1.transform.position = new Vector3(0, 0, 0);
            esfera2.transform.position = esfera1.transform.position + new Vector3(100f, 0f, 0f);
        }
    }
}
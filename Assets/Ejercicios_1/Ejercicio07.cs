using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercico07 : MonoBehaviour
    {
        void Start()
        {
            GameObject esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            esfera1.transform.position = new Vector3(0, 0, 0);
            esfera2.transform.position = esfera1.transform.position + new Vector3(100f, 0f, 0f);
            esfera3.transform.position = esfera2.transform.position + new Vector3(100f, 0f, 0f);

            //❕ CrearEsferas();
        }

        //❕
        void CrearEsferas()
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = Vector3.right * i * 100f;
            }
        }
    }
}
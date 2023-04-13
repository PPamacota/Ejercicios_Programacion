using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio03 : MonoBehaviour
    {
        /// <summary>
        /// Crear un script que genere un cubo al inicio y duplique su escala
        /// </summary>
        void Start()
        {
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);

            cubo.transform.localScale = new Vector3(2f, 2f, 2f);
            //❕ cubo.transform.localScale *= 2f;
        }
    }
}
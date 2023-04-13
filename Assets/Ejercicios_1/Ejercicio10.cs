using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>
    public class Ejercicio10 : MonoBehaviour
    {
        public string nombre = "";

        void Start()
        {
            GameObject[] gameObjects = GameObject.FindObjectsOfType<GameObject>();

            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].name = nombre;
            }
        }
    }
}
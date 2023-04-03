using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{

    /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>

    public string nombre = "";
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects = GameObject.FindObjectsOfType<GameObject>();

        for (int i = 0; i < gameObjects.Length; i++)
        {

            gameObjects[i].name = nombre;
            
        }

    }

    
}

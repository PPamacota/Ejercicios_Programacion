using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
/// </summary>


public class Ejercicio8 : MonoBehaviour
{
   
    void Start()
    {
        GameObject cubo1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cubo2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cubo3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubo1.transform.position = new Vector3(0, 0, 0);
        cubo1.transform.localScale = new Vector3(3f, 3f, 3f);

        cubo2.transform.position = cubo1.transform.position + new Vector3(7f, 0f, 0f);
        cubo2.transform.localScale = cubo1.transform.localScale * 2f;

        cubo3.transform.position = cubo2.transform.position + new Vector3(14f, 0f, 0f);
        cubo3.transform.localScale = cubo2.transform.localScale * 2f;
    }

 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
/// </summary>


public class Ejercicio9 : MonoBehaviour
{
    // 
    void Start()
    {
        GameObject esferaBase = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esferaBase.transform.localScale = new Vector3(1f, 1f, 1f);

        for (int i = 0; i < 11; i++)
        {
            GameObject otraEsfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            otraEsfera.transform.localScale = esferaBase.transform.localScale*2f;

            for (int j = 0; j < i; j++)
            {
                otraEsfera.transform.localScale = new Vector3(otraEsfera.transform.localScale.x * 2f, otraEsfera.transform.localScale.y * 2f, otraEsfera.transform.localScale.z * 2f);

            }
        }
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
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

            //❕ CrearFiguras(PrimitiveType.Cube, 3);
        }

        //❕
        public static void CrearFiguras(PrimitiveType figura, int cantidad, float separacion = 0f)
        {
            float x = -0.5f; //Para que el primero se dibuje en (0, 0, 0)
            for (int i = 0; i < cantidad; i++)
            {
                GameObject go = GameObject.CreatePrimitive(figura);
                float size = Mathf.Pow(2f, i); //1, 2, 4, 8, 16
                go.transform.localScale = Vector3.one * size;
                x += size/2f; //Empujamos el punto de creación la mitad del tamaño que tiene
                go.transform.position = new Vector3(x, 0f, 0f);
                x += size/2f; //Empujamos la otra mitad para retomar desde ahí en el próximo
                x += separacion; //Añadimos la separación que queremos entre cubos
            }
        }        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{ /// <summary>
  /// Crear un script que genere un cubo al inicio y duplique su escala
  /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubo.transform.localScale = new Vector3(2f, 2f, 2f);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class botonesInferiores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //se guarda la posicion original de MenuL accediendo a este a partir del script ya creado en el script llamado botones 
    }

    // Update is called once per frame
    void crear()
    {
        //al pulsar crear se abre un menL y vuelve a su posicion original desde la derecha y el menINF desde arriba hacia su posicion original
        //se crearan 5 funciones una para cada boton las cuales aran que el menINF de botones con un texTMP que diga ''se esta ''accion seleccionada por el boton'' un ''objeto presente en el raton'' para ello se debera usar taycast que detente el nombre del objeto seleciconado solo si este tiene la tag Elemento
        //aqui un ejemplo de como se deveria ver si el objeto se llama arbol y tiene la tag Elemento y el raton lo a seleccionado tras darle al boton rotar esto te permitiria rotar el arbol usando la rueda del raton y de paso saldria el mensaje en el menu info que diria ''se esta rotando un arbol''
        // es importante en los comentarios usar siempre /// y no // es decir sumarize en ves de comentarios para comprimir en un parrafo varias lineas de explicacion
    }
}


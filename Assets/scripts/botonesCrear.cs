using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class botonesCrear : MonoBehaviour
{
    // antes de empezar es importante tener en cuenta que habra varios botones con la misma funcion pero cada boton llamara a un objeto diferente.
    void Start()
    {
        //se almacena la posicion original de ''informacion'' 
    }

    // Update is called once per frame
    void Creamos()
    {
        //se genera un objeto en el cursor el cual sigue el movimiento de este
        //al hacer click se instancia con leantween dicho objeto en el escenario haciendo que ''cresca'' a su tamaño original y se crea otro objeto que siga al cursor el objeto que sigue al cursor no tiene colision pero el instanciado si
        //ademas usando leantween se llama a ''informacion'' desde arriba del todo haciendo que ''desciendia'' a su posicion original
        //es importante que el texto de informacion sea '' estas creando el objeto (nombre del objeto que se esta creando mediante prefab)'' 
        //ademas menuL se oculta usando el mismo leantween 
        //si hay que usar mas funciones o dividir esta funsion en varias hacerlo
    }
    void Cancelar()
    {
        //al cancelar se vuelve a enviar hacia ''arriba'' al objeto ''informacion'' 
        //ademas se vuelve a llamar al menuL 
        //y por ultimo se elimina el objeto en el raton usando una animacion de leantween que haga rotar el objeto y encojer para luego ser borrado. 
    }
}

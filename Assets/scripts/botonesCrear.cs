using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class botonesCrear : MonoBehaviour
{
    // antes de empezar es importante tener en cuenta que habra varios botones con la misma funcion pero cada boton llamara a un prefab asociado diferente todos estos botones se puede acceder desde el menu botones y son los ''bottonObjeto''.
    void Start()
    {
        //se almacena la posicion original de ''informacion'' 
    }

    // Update is called once per frame
    void FunciionArbol()
    {
        //se creara una funcion por cada uno de los 5 botones cada boton hara lo siguiente por ejemplo esta seria la funcion para el boton arbol (realmente es la funcion crear pero con varios parametros que se activan al pulsar cada boton,)
        //llamar a su prefab asociado
        //permitir al jugador crear mediante raycast el objeto. 
        //se genera un objeto en el cursor el cual sigue el movimiento de este y no tiene impacto ni colision para aparecer como referencia al objeto que se ''crearia'' si se usa el click derecho en el lugar donde este se generariaeste objeto no puede rotar
        //al hacer click en uno de los botones se instancia con leantween el prefab asociado a dicho boton en el escenario haciendo que ''cresca'' a su tamaño original y se crea otro objeto que siga al cursor el objeto que sigue al cursor no tiene colision pero el instanciado si
        //ademas menuL se oculta usando el mismo leantween y para crear el objeto usando raycast para detectar coliciones y al hacer click derecho generara el item en el lugar de impacto 
        //si hay que usar mas funciones o dividir esta funsion en varias hacerlo pero trata de mantener el script limpio y breve ademas la idea es que el objeto a crear se pueda rotar con la rueda del raton y previsualizar como se veria antes de crearlo (al mas puro estilo de citibuilders o sims).
    }
}

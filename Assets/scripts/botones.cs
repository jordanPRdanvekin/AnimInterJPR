using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class botones : MonoBehaviour
{
    [SerializeField]
    GameObject menuI;
    //añadir 10 gameobjets con serializefield 5 botones bottonObjeto y 5 llamados botonesInferiores otro para el menu info llamado ''menINF'' otro para el boton ''cancelar'' y ''abrir'' otro para el boton ''cerrar'' y por ultimo otro gameobject para ''menuL'' todos en publico para que otros script puedan acceder a ellos.
    Vector3 originalPosition; // Variable para almacenar la posición original importante para esta practica
    //nombre para los serializefield public de botonesInferiores = crear, rotar, escalar, mover, eliminar, 
    //nombre para los serializefiel public de  botonObjeto = arbol, paredYSuelo, cesped, hierba, tronco, 

    void Start()
    {
        // Guardar la posición original del menú (ademas si es necesario habria que guardar la posicion original de todos los gameobjets para los futuros scripts y que la animacion de leantween sea natural fluida y no desordene los botones u objetos. 
        originalPosition = menuI.transform.localPosition;

        // Mover el menú a la posición inicial desplazada hacia abajo
        menuI.transform.localPosition = new Vector3(originalPosition.x, originalPosition.y - 300f, originalPosition.z);
        menuI.SetActive(false);
    }

    public void abrirMenu()
    {
        // Activar el menú y moverlo a su posición original
        menuI.SetActive(true);
        LeanTween.moveLocalY(menuI, originalPosition.y, 1f).setEase(LeanTweenType.easeOutBounce); // Animación de subida
    }

    public void cerrarMenu()
    {
        // Mover el menú hacia abajo y desactivarlo al terminar la animación
        LeanTween.moveLocalY(menuI, originalPosition.y - 300f, 1f).setEase(LeanTweenType.easeInBounce).setOnComplete(() =>
        {
            menuI.SetActive(false);
        });
    }
    public void cancelar()
    {
        //al darle a cancelar cierra todos los menus usando la animacion leantween para hacer una ilucion de barrido donde los botones y menus salen desperdigados y encojen asta desaparecer luego se desactivan y se deja abrir menu dejando solo el boton de abrir menu
        //la idea es que la animacion sea aleatoria siempre que se pulse pero si no es posible para un novato no lo hagas 
    }
}


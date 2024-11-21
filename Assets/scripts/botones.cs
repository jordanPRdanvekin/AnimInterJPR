using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Botones : MonoBehaviour
{
    [Header("Men�s Principales")]
    [SerializeField] public GameObject menuI; // Men� principal.
    [SerializeField] public GameObject menuINF; // Men� de informaci�n.
    [SerializeField] public GameObject menuL; // Men� adicional.

    [Header("Botones de Control")]
    [SerializeField] public GameObject botonCancelar; // Bot�n para cancelar.
    [SerializeField] public GameObject botonAbrir; // Bot�n para abrir.
    [SerializeField] public GameObject botonCerrar; // Bot�n para cerrar.

    [Header("Botones Inferiores y Objetos")]
    [SerializeField] public List<GameObject> botonesInferiores; // Botones: Crear, Rotar, Escalar, Mover, Eliminar.
    [SerializeField] public List<GameObject> botonObjeto; // Botones: �rbol, ParedYSuelo, C�sped, Hierba, Tronco.

    private Vector3 menuIOriginalPosition; // Guarda la posici�n original del men� principal.

    /// <summary>
    /// Guarda la posici�n inicial de los men�s y desactiva todos al inicio.
    /// Esto asegura que las animaciones sean fluidas y consistentes.
    /// </summary>
    private void Start()
    {
        menuIOriginalPosition = menuI.transform.localPosition; // Guardar la posici�n inicial.
        menuI.SetActive(false); // Desactivar el men� principal.
        menuINF.SetActive(false); // Desactivar el men� de informaci�n.
        menuL.SetActive(false); // Desactivar el men� adicional.
    }

    /// <summary>
    /// Activa y anima el men� principal para que aparezca en pantalla.
    /// Usa LeanTween para animaciones fluidas con rebote.
    /// </summary>
    public void AbrirMenu()
    {
        menuI.SetActive(true); // Activar el men� (la idea seria devolver todos los botones y menus a sus lugares originales cuando se active el true y cuando vayan a desactivarse antes del false moverse fuera de la pantalla)
        LeanTween.moveLocalY(menuI, menuIOriginalPosition.y, 1f) // Moverlo hacia arriba.
            .setEase(LeanTweenType.easeOutBounce); // Usar animaci�n de rebote suave.
    }

    /// <summary>
    /// Anima el cierre del men� principal movi�ndolo hacia abajo y desactiv�ndolo.
    /// </summary>
    public void CerrarMenu()
    {
        LeanTween.moveLocalY(menuI, menuIOriginalPosition.y - 300f, 1f) // Mover hacia abajo.
            .setEase(LeanTweenType.easeInBounce) // Animaci�n de entrada suave.
            .setOnComplete(() => menuI.SetActive(false)); // Desactivarlo al terminar.
    }

    /// <summary>
    /// Cierra todos los men�s activos en la escena, con animaciones para cada uno.
    /// </summary>
    public void Cancelar()
    {
        // Lista de men�s a cerrar.
        List<GameObject> menus = new List<GameObject> { menuI, menuINF, menuL };

        foreach (GameObject menu in menus)
        {
            if (menu.activeSelf) // Solo cerrar si est� activo.
            {
                LeanTween.moveLocalY(menu, menuIOriginalPosition.y - 300f, 1f) // Mover hacia abajo (la idea es que se movieran de forma aleatoria con un random value).
                    .setEase(LeanTweenType.easeInBounce)
                    .setOnComplete(() => menu.SetActive(false)); // Desactivarlo al terminar.
            }
        }
    }
}


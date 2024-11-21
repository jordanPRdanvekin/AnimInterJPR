using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Botones : MonoBehaviour
{
    [Header("Menús Principales")]
    [SerializeField] public GameObject menuI; // Menú principal.
    [SerializeField] public GameObject menuINF; // Menú de información.
    [SerializeField] public GameObject menuL; // Menú adicional.

    [Header("Botones de Control")]
    [SerializeField] public GameObject botonCancelar; // Botón para cancelar.
    [SerializeField] public GameObject botonAbrir; // Botón para abrir.
    [SerializeField] public GameObject botonCerrar; // Botón para cerrar.

    [Header("Botones Inferiores y Objetos")]
    [SerializeField] public List<GameObject> botonesInferiores; // Botones: Crear, Rotar, Escalar, Mover, Eliminar.
    [SerializeField] public List<GameObject> botonObjeto; // Botones: Árbol, ParedYSuelo, Césped, Hierba, Tronco.

    private Vector3 menuIOriginalPosition; // Guarda la posición original del menú principal.

    /// <summary>
    /// Guarda la posición inicial de los menús y desactiva todos al inicio.
    /// Esto asegura que las animaciones sean fluidas y consistentes.
    /// </summary>
    private void Start()
    {
        menuIOriginalPosition = menuI.transform.localPosition; // Guardar la posición inicial.
        menuI.SetActive(false); // Desactivar el menú principal.
        menuINF.SetActive(false); // Desactivar el menú de información.
        menuL.SetActive(false); // Desactivar el menú adicional.
    }

    /// <summary>
    /// Activa y anima el menú principal para que aparezca en pantalla.
    /// Usa LeanTween para animaciones fluidas con rebote.
    /// </summary>
    public void AbrirMenu()
    {
        menuI.SetActive(true); // Activar el menú (la idea seria devolver todos los botones y menus a sus lugares originales cuando se active el true y cuando vayan a desactivarse antes del false moverse fuera de la pantalla)
        LeanTween.moveLocalY(menuI, menuIOriginalPosition.y, 1f) // Moverlo hacia arriba.
            .setEase(LeanTweenType.easeOutBounce); // Usar animación de rebote suave.
    }

    /// <summary>
    /// Anima el cierre del menú principal moviéndolo hacia abajo y desactivándolo.
    /// </summary>
    public void CerrarMenu()
    {
        LeanTween.moveLocalY(menuI, menuIOriginalPosition.y - 300f, 1f) // Mover hacia abajo.
            .setEase(LeanTweenType.easeInBounce) // Animación de entrada suave.
            .setOnComplete(() => menuI.SetActive(false)); // Desactivarlo al terminar.
    }

    /// <summary>
    /// Cierra todos los menús activos en la escena, con animaciones para cada uno.
    /// </summary>
    public void Cancelar()
    {
        // Lista de menús a cerrar.
        List<GameObject> menus = new List<GameObject> { menuI, menuINF, menuL };

        foreach (GameObject menu in menus)
        {
            if (menu.activeSelf) // Solo cerrar si está activo.
            {
                LeanTween.moveLocalY(menu, menuIOriginalPosition.y - 300f, 1f) // Mover hacia abajo (la idea es que se movieran de forma aleatoria con un random value).
                    .setEase(LeanTweenType.easeInBounce)
                    .setOnComplete(() => menu.SetActive(false)); // Desactivarlo al terminar.
            }
        }
    }
}


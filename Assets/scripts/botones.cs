using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class botones : MonoBehaviour
{
    [SerializeField]
    GameObject menuI;
    Vector3 originalPosition; // Variable para almacenar la posición original

    void Start()
    {
        // Guardar la posición original del menú
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
}


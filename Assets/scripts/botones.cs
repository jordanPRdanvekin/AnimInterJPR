using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class botones : MonoBehaviour
{
    [SerializeField]
    GameObject menuI;
    Vector3 originalPosition; // Variable para almacenar la posici�n original

    void Start()
    {
        // Guardar la posici�n original del men�
        originalPosition = menuI.transform.localPosition;

        // Mover el men� a la posici�n inicial desplazada hacia abajo
        menuI.transform.localPosition = new Vector3(originalPosition.x, originalPosition.y - 300f, originalPosition.z);
        menuI.SetActive(false);
    }

    public void abrirMenu()
    {
        // Activar el men� y moverlo a su posici�n original
        menuI.SetActive(true);
        LeanTween.moveLocalY(menuI, originalPosition.y, 1f).setEase(LeanTweenType.easeOutBounce); // Animaci�n de subida
    }

    public void cerrarMenu()
    {
        // Mover el men� hacia abajo y desactivarlo al terminar la animaci�n
        LeanTween.moveLocalY(menuI, originalPosition.y - 300f, 1f).setEase(LeanTweenType.easeInBounce).setOnComplete(() =>
        {
            menuI.SetActive(false);
        });
    }
}


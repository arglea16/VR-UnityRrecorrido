using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ShangeEcene_IngI_Inside : MonoBehaviour
{
    private string ingInside = "Piso_PB";
    public GameObject buttonIng;
    public Transform controller;
    void Update()
    {
        // Verifica si el botón está siendo presionado
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && IsButtonPressed())
        {
            OnButtonPress();
        }
    }
    //verificar si el controlador esta sobre el button
    private bool IsButtonPressed()
    {
        // Realiza un raycast desde la posición del controlador
        RaycastHit hit;
        Ray ray = new Ray(controller.position, controller.forward);

        // Dibuja el raycast en la escena para visualización
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 3f);
        Debug.Log("Ray Origin: " + ray.origin + ", Ray Direction: " + ray.direction);


        // Verifica si el raycast golpea el botón
        if (Physics.Raycast(ray, out hit))
        {
            // Comprueba si el objeto golpeado es el botón
            if (hit.collider.gameObject == buttonIng)
            {
                return true; // El controlador está sobre el botón
            }
        }
        return false; // No está sobre el botón
    }

    private void OnButtonPress()
    {
        // cambiar ecena 
        SceneManager.LoadScene(ingInside);
    }

}

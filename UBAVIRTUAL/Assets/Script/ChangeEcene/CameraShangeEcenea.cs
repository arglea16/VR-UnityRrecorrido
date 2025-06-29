using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraShangeEcenea : MonoBehaviour
{
    
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisión detectada con: " + other.gameObject.name); // Verifica qué objeto está colisionando
        if (other.CompareTag("Sphere"))
        {
            Debug.Log("Collisiono");
            Invoke("SchangeEcene", 2f);
        }
    }

    private void SchangeEcene()
    {
        SceneManager.LoadScene("Piso_PB");
    }
}

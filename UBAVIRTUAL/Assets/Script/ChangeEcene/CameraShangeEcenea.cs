using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraShangeEcenea : MonoBehaviour
{
    
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisi�n detectada con: " + other.gameObject.name); // Verifica qu� objeto est� colisionando
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

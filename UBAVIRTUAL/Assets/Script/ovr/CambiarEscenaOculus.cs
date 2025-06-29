using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaOculus : MonoBehaviour
{
    public string nombreDeLaEscena;
    public AudioClip sonido;
    private AudioSource fuente;

    void Start()
    {
        fuente = gameObject.AddComponent<AudioSource>();
        fuente.playOnAwake = false;
    }

    public void Cambiar()
    {
        if (sonido != null)
            fuente.PlayOneShot(sonido);

        Invoke(nameof(Cargar), 0.5f); // espera para que suene el audio
    }

    void Cargar()
    {
        SceneManager.LoadScene(nombreDeLaEscena);
    }
}

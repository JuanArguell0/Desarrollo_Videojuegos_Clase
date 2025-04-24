using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject canvasMenu;   
    public GameObject playerObject;   
    
    void Start()
    {

        if (canvasMenu != null)
            canvasMenu.SetActive(true);
            
        if (playerObject != null)
            playerObject.SetActive(false);
    }

    public void IniciarJuego()
    {
        Time.timeScale = 1f;
        
        if (canvasMenu != null)
            canvasMenu.SetActive(false);
            
        if (playerObject != null)
            playerObject.SetActive(true);
            
        Debug.Log("Juego iniciado");
    }

    public void SalirDelJuego()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
    
    public void VolverAlMenu()
    {
        if (canvasMenu != null)
            canvasMenu.SetActive(true);
            
        if (playerObject != null)
            playerObject.SetActive(false);
    }
}
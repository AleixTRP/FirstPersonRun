using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void OnClick()
    {
        // Cargar la escena del men� principal
        SceneManager.LoadScene(0);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void OnClick()
    {
        // Cargar la escena del menú principal
        SceneManager.LoadScene(0);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputHandler : MonoBehaviour
{
    [SerializeField]
    private string _menuSceneName;

    private void Update()
    {
        if (Input.GetKeyDown((KeyCode.Escape)))
        {
            if (_menuSceneName != SceneManager.GetActiveScene().name)
            {
                SceneManager.LoadScene(_menuSceneName);
            }
            else
            {
                Application.Quit();
            }
        }
    }
}

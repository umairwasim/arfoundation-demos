using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private int sceneIndex = 0;
    public void ButtonClicked() => SceneManager.LoadScene(sceneIndex);
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }
}
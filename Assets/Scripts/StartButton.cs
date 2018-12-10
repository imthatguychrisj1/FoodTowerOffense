using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    public void OnClicked()
    {
        GameManager.Instance.AdvanceLevel();
        SceneManager.LoadScene(GameManager.Instance.CurrentLevel);
    }
}

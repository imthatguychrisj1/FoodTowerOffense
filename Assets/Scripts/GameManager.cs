using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance = null;
    public static GameManager Instance { get { return instance; } }

    public int numberOfScenes = 1;
    private int currentLevel = 0;
    public string CurrentLevel
    {
        get
        {
            switch (currentLevel)
            {
                case 1:
                    return "GameScreen";  // add all levels here to load
                case 2:
                    return "MainMenu";
                case 3:
                    return "PauseMenu";
                default:
                    return "StartGUI";
            }
        }
    }
    [HideInInspector]
    public string Winner { get; set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AdvanceLevel()
    {
        currentLevel += 1;
        if (currentLevel > numberOfScenes)
        {
            currentLevel = 0;
        }
    }
}

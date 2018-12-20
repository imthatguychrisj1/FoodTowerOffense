using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
    public string BuildScene;

    // Use this for initialization
    void Start()
    {
        definedButton = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Debug.Log("Button Clicked");
           OnClick.Invoke();
        }
    }
}
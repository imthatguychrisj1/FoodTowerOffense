using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public GameObject towerPrefab
    {
        get
        {
            return towerPrefab;
        }
    }

    void Awake ()
    {
        //Check if instance already exists
        if (Instance == null)
            //if not, set instance to this
            Instance = this;
        //If instance already exists and it's not this:
        else if (Instance != this)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
    }

    public PlaceTower ClickedBtn { get; private set; }

    public void PickTower (PlaceTower tower)
    {
        this.ClickedBtn = tower;
    }
}

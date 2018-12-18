using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehaviour : MonoBehaviour {

    public Text healthLabel;
    public GameObject[] healthIndicator;

    private int health;
    private bool gameOver;

    public int Health
    { get { return health;}
    set { if(value < health)
            {}
            health = value;
            //healthLabel.text = "Health: " + health;
            if(health <=0 && !gameOver)
            {
                gameOver = true;
            }
            for (int i = 0; i < healthIndicator.Length; i++)
            {
                if(i < Health)
                {
                    healthIndicator[i].SetActive(true);
                }
                else
                {
                    healthIndicator[i].SetActive(false);
                }
            }
        }
    }

	// Use this for initialization
	void Start () {
        Health = 5;
	}
}

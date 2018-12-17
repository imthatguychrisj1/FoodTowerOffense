using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {

    //public GameObject towerPrefab;
    public GameObject breadTower;
    private GameObject tower;



    private bool CanPlaceTower()
    {
        return tower == null;
    }

    //1
    void OnMouseDown()
    {
        //2
        if (CanPlaceTower())

            tower = (GameObject)Instantiate(breadTower, transform.position, transform.rotation);
            Debug.Log("Tower Placed!");
            // TODO: Deduct gold
        
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

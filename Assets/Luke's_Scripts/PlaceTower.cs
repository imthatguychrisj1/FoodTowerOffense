﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {

    public GameObject towerPrefab;
    private GameObject tower;

    private bool CanPlaceTower()
    {
        return tower == null;
    }

    //1
    void OnMouseUp()
    {
        //2
        if (CanPlaceTower())
        {
            //3
            tower = (GameObject)
                Instantiate(towerPrefab, transform.position, Quaternion.identity);

            // TODO: Deduct gold
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

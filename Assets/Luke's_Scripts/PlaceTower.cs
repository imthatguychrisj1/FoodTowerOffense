using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {

    //public GameObject towerPrefab;
    private GameObject tower;
    public GameObject towerPrefab;

    private bool CanPlaceTower()
    {
        return tower == null;
    }

    //1
    void OnMouseDown()
    {
        //2
        if (CanPlaceTower())

            tower = (GameObject)Instantiate(GameManager.Instance.ClickedBtn.towerPrefab, transform.position, transform.rotation);
            Debug.Log("Tower Placed!");
            // TODO: Deduct gold
        
    }

}

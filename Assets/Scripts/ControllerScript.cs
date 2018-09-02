using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    //private GameObject selectedEnemy;
    private string selectedEnemy;
    private EnemyScript enemyInstance;
    public Transform prefab;
    private Transform myShip;

	// Use this for initialization
	void Start () {
        myShip = GetComponentInParent<Transform>();
    }

    // Update is called once per frame
    void Update() { 
    
    }

    public void UpdateSelectedEnemy(EnemyScript enemy)
    {
        enemyInstance = enemy;

        Debug.Log(enemyInstance.name + " was selected");

       for (int i = 0; i < 1; i++)
        {
            Instantiate(prefab, myShip.position, myShip.rotation);
        }
        
    }

    public EnemyScript GetSelectedEnemy()
    {
            return enemyInstance;
    }


}

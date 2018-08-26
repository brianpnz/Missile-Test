using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    //private GameObject selectedEnemy;
    private string selectedEnemy;
    private EnemyScript enemyInstance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateSelectedEnemy(EnemyScript enemy)
    {
        enemyInstance = enemy;

        Debug.Log(enemyInstance.name + " was selected");
        
    }

    public EnemyScript GetSelectedEnemy()
    {
            return enemyInstance;
    }


}

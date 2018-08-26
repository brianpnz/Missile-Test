using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    //private GameObject selectedEnemy;
    private string selectedEnemy;
    private EnemyScript enemyInstance;
    public Transform prefab;

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

        for (int i = 0; i < 6; i++)
        {
            Instantiate(prefab, new Vector3(i * 0.5F, 0, 0), Quaternion.identity);
        }
        
    }

    public EnemyScript GetSelectedEnemy()
    {
            return enemyInstance;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private ControllerScript controller;

    private void Awake()
    {
        controller = GameObject.FindObjectOfType<ControllerScript>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        controller.UpdateSelectedEnemy(this);
    }

    public void Hit()
    {
        transform.Rotate(0f, 1f, 0f);
    }
}

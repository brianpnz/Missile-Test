using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

    private ControllerScript controller;

    public float startHealth = 100.0f;
    private float health;

    [Header("Unity Stuff")]
    public Image healthBar;

    private void Awake()
    {
        controller = GameObject.FindObjectOfType<ControllerScript>();
    }

    // Use this for initialization
    void Start () {
        health = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            controller.UpdateSelectedEnemy(this);
        }
        
    }

    public void Hit()
    {
        health = health - 10;
        healthBar.fillAmount = health / startHealth;

        transform.Rotate(0f, 1f, 0f);
    }
}

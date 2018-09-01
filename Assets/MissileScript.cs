using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour
{

    private GameObject enemy;
    private Transform target;
    private ControllerScript controller;
    
    public float rocketTurnSpeed = 15.0f;
    public float rocketSpeed = 15.0f;
    public float randomOffset = 5.0f;

    private float timerSinceLaunch_Contor;
    private float objectLifeTimerValue;


    private void Awake()
    {
        controller = GameObject.FindObjectOfType<ControllerScript>();
    }

    // Use this for initialization
    void Start()
    {
        //rocketTurnSpeed = 5.0f;
        //rocketSpeed = 15.0f;
        //randomOffset = 0.0f;
        timerSinceLaunch_Contor = 0;
        objectLifeTimerValue = 20;

        if (target)
        {
            target = enemy.gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the missile doesn't already have a target enemy
        if (!enemy)
        {
            //Check to see if one has been clicked on
            if (controller.GetSelectedEnemy())
            {
                enemy = controller.GetSelectedEnemy().gameObject;
                target = enemy.gameObject.transform;
            }
        }


        timerSinceLaunch_Contor += Time.deltaTime;

        if (target != null)
        {
            if (timerSinceLaunch_Contor > 1)
            {
                if ((target.position - transform.position).magnitude > 50)
                {
                    randomOffset = 10.0f;
                    rocketTurnSpeed = 90.0f;
                }
                else
                {
                    randomOffset = 0.5f;
                    //if close to target
                    if ((target.position - transform.position).magnitude < 10)
                    {
                        rocketTurnSpeed = 180.0f;
                    }
                }
            }

            Vector3 direction = target.position - transform.position + Random.insideUnitSphere * randomOffset;
            direction.Normalize();
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), rocketTurnSpeed * Time.deltaTime);
            transform.Translate(Vector3.forward * rocketSpeed * Time.deltaTime);
        }

        if (timerSinceLaunch_Contor > objectLifeTimerValue)
        {
            Destroy(transform.gameObject, 1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Enemy3")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<EnemyScript>().Hit();
            //transform.gameObject.
            Destroy(transform.gameObject);
        }
    }
}
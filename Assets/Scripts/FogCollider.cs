using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogCollider : MonoBehaviour
{
    public Animator transition;
    public string CollisionNameCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider otro)
    {
        CollisionNameCheck = otro.gameObject.name;

        if (CollisionNameCheck == "Catto")
        {

            transition.SetTrigger("start");
            transition.ResetTrigger("out");


        }

    }

    void OnTriggerExit(Collider otro)
    {
        CollisionNameCheck = otro.gameObject.name;

        if (CollisionNameCheck == "Catto")
        {

            transition.SetTrigger("out");
            transition.ResetTrigger("start");


        }

    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steps : MonoBehaviour
{
    
    public float oldPos;
    public float oldPosx;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        oldPos = transform.position.z;
        oldPosx = transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oldPos < transform.position.z || oldPosx < transform.position.x || oldPos > transform.position.z || oldPosx > transform.position.x)
        {
            Debug.Log("moving");
            audioSource.enabled = true;
            

        }
        if(oldPos == transform.position.z && oldPosx == transform.position.x){
           audioSource.enabled = false;
             Debug.Log("still"); 
        }
        oldPos = transform.position.z;
        oldPosx = transform.position.x;
    }
}
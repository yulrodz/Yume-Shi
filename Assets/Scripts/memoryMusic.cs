using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public string CollisionNameCheck;
    public string CollisionNameCheck2;
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

            audioSource.volume = 0f;
            audioSource2.volume = 0.7f;


        }
        
    }
    void OnTriggerExit(Collider otro2)
    {
        CollisionNameCheck2 = otro2.gameObject.name;

        if (CollisionNameCheck2 == "Catto")
        {

            audioSource.volume = 0.5f;
            audioSource2.volume = 0f;


        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TextCollider : MonoBehaviour
{
    public bool StartDialogue;
    public string CollisionNameCheck;
    public static int DialogueScript;

    public AudioClip GiveMeAtention;
    public AudioSource hiloMusical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (CollisionNameCheck == "Catto" && Mouse.current.leftButton.isPressed == true)
        {
            DialogueScript ++;

        }
        
    }

     void OnTriggerEnter(Collider otro)
    {
        CollisionNameCheck = otro.gameObject.name;
        hiloMusical.PlayOneShot(GiveMeAtention, 0.05f);

        if (CollisionNameCheck == "Catto")
        {
            StartDialogue = true;

        }
    }

     void OnTriggerExit(Collider otro)
    {
        CollisionNameCheck = otro.gameObject.name;

        if (CollisionNameCheck == "Catto")
        {
            StartDialogue = false;

        }
    }
}

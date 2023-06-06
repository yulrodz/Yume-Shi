using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class teleportRoom : MonoBehaviour
{
    public Animator transition;//animation object
    public Animator camera;
    public string CollisionNameCheck;
    bool ColliderCheck = false;
    public float Rnumber;
    
    //audio
    public AudioClip Teleport;
    public AudioSource hiloMusical;
    // Start is called before the first frame update
    //checks to not repeat worlds

    public static bool Meat = false;
    public static bool Traffic = false;
    public static bool Cubos = false;
    public static bool Inverted = false;
    public bool teleport = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Traffic == true && Meat == true && Cubos == true && Inverted == true){
        Debug.Log ("END GAME");

       }else if (Mouse.current.leftButton.isPressed == true && ColliderCheck == true)
        
        {
            Rnumber = Random.Range(0f, 4f);
            StartCoroutine(waiter());
        }

    }
     void OnTriggerEnter(Collider otro)
    {
        CollisionNameCheck = otro.gameObject.name;

        if (CollisionNameCheck == "Catto")
        {
            camera.ResetTrigger("out");
            camera.SetTrigger("in");
            
            ColliderCheck = true;


        }

    }
     void OnTriggerExit(Collider otro)
    {
        CollisionNameCheck = otro.gameObject.name;

        if (CollisionNameCheck == "Catto")
        {

            camera.ResetTrigger("in");
            camera.SetTrigger("out");
            
            ColliderCheck = false;


        }

    }
    IEnumerator waiter()
    {
        //animation
        transition.SetTrigger("Start");
        hiloMusical.PlayOneShot(Teleport, 0.05f);
      


        yield return new WaitForSeconds(1.5f);//play animation and wait
        while(teleport == false)
        {
             if (Rnumber <= 1 && Meat == false)
            {
            Meat = true;
            teleport = true;
            SceneManager.LoadScene("Meat");
            

        }
        if (Rnumber > 1 && Rnumber < 2 && Traffic == false)
        {    Traffic = true;
            teleport = true;
            SceneManager.LoadScene("Traffic");
            


        }
         if (Rnumber > 2 && Rnumber < 3 && Cubos == false)
        {    Cubos = true;
            teleport = true;
            SceneManager.LoadScene("cubos");
            

        }
         if (Rnumber > 3 && Rnumber < 4 && Inverted == false)
         {
            Inverted = true;
            teleport = true;
            SceneManager.LoadScene("inverted room");
            

        }
        Rnumber = Random.Range(0f, 4f);
        }

       
        
        //load
    }

}



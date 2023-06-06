using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour
{
    public Animator transition;//animation object
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

        if (CollisionNameCheck == "Catto"){
           
           StartCoroutine(waiter());

          
        }
            
 

    
    

    }//end trigger

    IEnumerator waiter(){
         //animation
           transition.SetTrigger("Start");
    
        yield return new WaitForSeconds (0.7f);//play animation and wait
         SceneManager.LoadScene("Meat");//load
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MemoryCollect : MonoBehaviour
{
    
    public string CollisionNameCheck;
    
    public RawImage keyImage;
    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        keyImage.enabled = false;
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
            
            Score++;

            

            keyImage.enabled = true;
            StartCoroutine(waiter2());

           
        }

    }

    IEnumerator waiter2()
    {
       

       
        yield return new WaitForSeconds(2f);
        keyImage.enabled = false;
        Debug.Log("Deberia desaparecer la muy puta");
        SceneManager.LoadScene("The room");
        Destroy(this.gameObject, 0.1f);

    }
   

}

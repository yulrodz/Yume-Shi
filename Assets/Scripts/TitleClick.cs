using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleClick : MonoBehaviour
{
    public AudioSource hiloMusical;
    public AudioClip SonidoDead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Mouse.current.leftButton.isPressed);
        if (Mouse.current.leftButton.isPressed == true)
        {
            
            SceneManager.LoadScene("The room");
            hiloMusical.PlayOneShot(SonidoDead, 1f);

        }
    }
}

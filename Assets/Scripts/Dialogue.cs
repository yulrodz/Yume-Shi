using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;



public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public bool CollisionDialogue=false;
    public string CollisionNameCheck;
    bool hell;

    public Image Image;
    
    

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().color -= new Color(0f, 0f, 0f, 1f);

         textComponent.text = string.Empty;
         
    }

    // Update is called once per frame
    void Update()
    {
        if (CollisionDialogue == true && hell == false){
            GetComponent<Image>().color += new Color(0f, 0f, 0f, 1f);
            gameObject.SetActive(true);
            StartDialogue();
            hell = true;
         }
        if (Input.GetMouseButtonDown(0) && CollisionDialogue == true)
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }
    IEnumerator TypeLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            textComponent.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }

    }
    public void NextLine()
    {
        if (index < 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }else
        {
            gameObject.SetActive(false);
        }



    }
    void OnTriggerEnter(Collider otro)
    {
        CollisionNameCheck = otro.gameObject.name;
        

        if (CollisionNameCheck == "Catto")
        {
            CollisionDialogue = true;

        }
    }

}

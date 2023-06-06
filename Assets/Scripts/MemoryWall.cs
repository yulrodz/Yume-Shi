using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryWall : MonoBehaviour
{
    public int Score;
    public GameObject mem1;
    public GameObject mem2;
    public GameObject mem3;
    public GameObject mem4;
    // Start is called before the first frame update
    void Start()
    {
        mem1.SetActive(false);
            mem2.SetActive(false);
            mem3.SetActive(false);
            mem4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Score = MemoryCollect.Score;
        if (Score == 1){
            mem1.SetActive(true);
        }
        if (Score == 2){
            mem1.SetActive(true);
            mem2.SetActive(true);
        }
         if (Score == 3){
            mem1.SetActive(true);
            mem2.SetActive(true);
            mem3.SetActive(true);
        }
           if (Score == 4){
            mem1.SetActive(true);
            mem2.SetActive(true);
            mem3.SetActive(true);
            mem4.SetActive(true);
        }
    }
}

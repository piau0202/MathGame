using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject option2;
    public GameObject option3;
    public bool isCorrect;
    

    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
        if (isCorrect )
        {
            GetComponent<TextMesh>().color = Color.green;
        }
       else 
        {
            GetComponent<TextMesh>().color = Color.red;
            if (option2.GetComponent<Option2>().isCorrect )
            {
                option2.GetComponent<TextMesh>().color = Color.yellow;
            }

            if (option3.GetComponent<Option3>().isCorrect)
            {
                option3.GetComponent<TextMesh>().color = Color.yellow;
            }
        }


    }

}


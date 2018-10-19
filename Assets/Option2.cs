using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option2 : MonoBehaviour
{
    public GameObject option1;
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

        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;
            if (option1.GetComponent<Option>().isCorrect)
            {
                option1.GetComponent<TextMesh>().color = Color.yellow;
            }
            if (option3.GetComponent<Option3>().isCorrect)
            {
                option3.GetComponent<TextMesh>().color = Color.yellow;
            }
        }
    }
}

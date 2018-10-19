using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option3 : MonoBehaviour {

    // Use this for initialization
    public GameObject option2;
    public GameObject option1;
    public bool  isCorrect;


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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

            if (option2.GetComponent<Option2>().isCorrect)
            {
                option2.GetComponent<TextMesh>().color = Color.yellow;
            }



        }


    }
}

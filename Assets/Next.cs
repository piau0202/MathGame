﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

     void OnMouseDown()
    {
        
        GameObject.Find("core").GetComponent<GameController>().GenerateQuestion();


    }
}

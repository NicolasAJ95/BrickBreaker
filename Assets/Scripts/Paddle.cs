﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 paddlePos = new Vector3 (this.transform.position.x, this.transform.position.y, 0);
        float mousePosInBlocks = ((Input.mousePosition.x / Screen.width) * 16);
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        this.transform.position = paddlePos;
    }
}
using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Paddle paddle;
    private bool hasStarted = false;
    private bool grounded = true;
    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
	
        paddleToBallVector = this.transform.position - paddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
        }
        if (Input.GetMouseButtonDown(0) && grounded)
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 10f);           
            grounded = false;
        }



	}
}

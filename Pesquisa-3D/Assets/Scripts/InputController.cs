using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

    private MovementController movementController;
    string input;


	// Use this for initialization
	void Start () {
        

        movementController = GetComponent<MovementController>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxis("Horizontal") < 0)
        {
            //Debug.Log("left");
            input = "LEFT";
            movementController.sendInput(input);
        }
        else if(Input.GetAxis("Horizontal") > 0)
        {
            //Debug.Log("right");
            input = "RIGHT";
            movementController.sendInput(input);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            //Debug.Log("back");
            input = "BACK";
            movementController.sendInput(input);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            //Debug.Log("front");
            input = "FRONT";
            movementController.sendInput(input);
        }
        if (Input.GetButtonDown("Jump"))
        {
            //Debug.Log("jump");
            input = "JUMP";
            movementController.sendInput(input);
        }
    }
}

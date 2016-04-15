using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    [SerializeField]
    private GameObject ObjectToMove;
    [SerializeField]
    private float StepDistance = 0.1f;
    float zMovement;
    float xMovement;


    private bool isJumping = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(ObjectToMove.GetComponent<Rigidbody>().velocity.y == 0)
        {
            isJumping = false;
        }
        zMovement = Mathf.Cos(ObjectToMove.transform.eulerAngles.y * Mathf.Deg2Rad) * StepDistance;
        xMovement = Mathf.Sin(ObjectToMove.transform.eulerAngles.y * Mathf.Deg2Rad) * StepDistance;
    }

    public void sendInput(string input)
    {
        switch(input)
        {
            case "JUMP":
                jumpObject();
                break;
            case "FRONT":
                moveObjectToFront();
                break;
            case "BACK":
                moveObjectToBack();
                break;
            case "LEFT":
                moveObjectToLeft();
                break;
            case "RIGHT":
                moveObjectToRight();
                break;
        }
    }

    private void jumpObject()
    {
        if(!isJumping)
        {
            isJumping = true;
            ObjectToMove.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000));
            //Debug.Log("jump");
        }
    }

    private void moveObjectToLeft()
    {
        //Debug.Log("front");
        //Debug.Log("x:" + xMovement + "z:" + zMovement);

        Vector3 newPosition =
            new Vector3(ObjectToMove.transform.position.x - zMovement,
            ObjectToMove.transform.position.y,
            ObjectToMove.transform.position.z);

        ObjectToMove.transform.position = newPosition;
    }
    private void moveObjectToRight()
    {
        //Debug.Log("front");


        Vector3 newPosition =
            new Vector3(ObjectToMove.transform.position.x + zMovement,
            ObjectToMove.transform.position.y,
            ObjectToMove.transform.position.z);

        ObjectToMove.transform.position = newPosition;
    }
    private void moveObjectToBack()
    {
        //Debug.Log("front");


        Vector3 newPosition =
            new Vector3(ObjectToMove.transform.position.x - xMovement,
            ObjectToMove.transform.position.y,
            ObjectToMove.transform.position.z - zMovement);

        ObjectToMove.transform.position = newPosition;
    }

    private void moveObjectToFront()
    {
        //Debug.Log("front");
        
        //Debug.Log("rotation:" + ObjectToMove.transform.eulerAngles.y);
        //Debug.Log("zStep:" + zMovement + "/xStep:" + xMovement);

        Vector3 newPosition = 
            new Vector3(ObjectToMove.transform.position.x + xMovement,
            ObjectToMove.transform.position.y,
            ObjectToMove.transform.position.z + zMovement);

        ObjectToMove.transform.position = newPosition;
    }
}

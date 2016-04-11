using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    [SerializeField]
    private GameObject ObjectToMove;
    [SerializeField]
    private float StepDistance = 0.1f;


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
                jumpObject();
                break;
            case "RIGHT":
                jumpObject();
                break;
        }
    }

    private void jumpObject()
    {
        if(!isJumping)
        {
            isJumping = true;
            ObjectToMove.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000));
        }
    }

    private void moveObjectToBack()
    {
        //Debug.Log("front");

        float zMovement;
        float xMovement;

        zMovement = Mathf.Cos(ObjectToMove.transform.rotation.y * Mathf.Deg2Rad) * StepDistance;
        xMovement = Mathf.Sin(ObjectToMove.transform.rotation.y * Mathf.Deg2Rad) * StepDistance;

        Vector3 newPosition =
            new Vector3(ObjectToMove.transform.position.x - xMovement,
            ObjectToMove.transform.position.y,
            ObjectToMove.transform.position.z - zMovement);

        ObjectToMove.transform.position = newPosition;
    }

    private void moveObjectToFront()
    {
        //Debug.Log("front");
        
        float zMovement;
        float xMovement;

        zMovement = Mathf.Cos(ObjectToMove.transform.rotation.y * Mathf.Deg2Rad) * StepDistance;
        xMovement = Mathf.Sin(ObjectToMove.transform.rotation.y * Mathf.Deg2Rad) * StepDistance;

        Debug.Log("zStep:" + zMovement + "/xStep:" + xMovement);

        Vector3 newPosition = 
            new Vector3(ObjectToMove.transform.position.x + xMovement,
            ObjectToMove.transform.position.y,
            ObjectToMove.transform.position.z + zMovement);

        ObjectToMove.transform.position = newPosition;
    }
}

using UnityEngine;
using System.Collections;

public class RotationController : MonoBehaviour {

    [SerializeField]
    private GameObject ObjectToRotate;
    [SerializeField] private float stepDistance = 2f;
    private Vector3 newRotation;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    public void sendInput(float horizontal)
    {
        newRotation = new Vector3(
            ObjectToRotate.transform.eulerAngles.x,
            ObjectToRotate.transform.eulerAngles.y + stepDistance,
            ObjectToRotate.transform.eulerAngles.z
            );
        ObjectToRotate.transform.eulerAngles = newRotation;
    }
    public void sendInput(string input)
    {
        switch (input)
        {
            case "UP":
                rotateObjectUp();
                break;
            case "DOWN":
                rotateObjectDown();
                break;
            case "LEFT":
                rotateObjectLeft();
                break;
            case "RIGHT":
                rotateObjectRight();
                break;
        }
    }
    private void rotateObjectUp()
    {
        newRotation = new Vector3(
            Camera.main.transform.eulerAngles.x - stepDistance,
            Camera.main.transform.eulerAngles.y,
            Camera.main.transform.eulerAngles.z);

        Camera.main.transform.eulerAngles = newRotation;
       //ObjectToRotate.transform.eulerAngles.x += 1;
       //Debug.Log("jump");
    }
    private void rotateObjectDown()
    {
        newRotation = new Vector3(
            Camera.main.transform.eulerAngles.x + stepDistance,
            Camera.main.transform.eulerAngles.y,
            Camera.main.transform.eulerAngles.z);

        Camera.main.transform.eulerAngles = newRotation;
        //Debug.Log("jump");
    }
    private void rotateObjectLeft()
    {
        newRotation = new Vector3(
            Camera.main.transform.eulerAngles.x,
            Camera.main.transform.eulerAngles.y - stepDistance,
            Camera.main.transform.eulerAngles.z);

        Camera.main.transform.eulerAngles = newRotation;

        //Debug.Log("jump");
    }
    private void rotateObjectRight()
    {
        newRotation = new Vector3(
            Camera.main.transform.eulerAngles.x,
            Camera.main.transform.eulerAngles.y + stepDistance,
            Camera.main.transform.eulerAngles.z);

        Camera.main.transform.eulerAngles = newRotation;

        //Debug.Log("jump");
    }
}

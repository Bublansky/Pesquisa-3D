using UnityEngine;
using System.Collections;

public class MouseRotation : MonoBehaviour {

    //private RotationController rotationController;
    private string input;
    private float horizontalSpeed = 2.0f;
    private float verticalSpeed = 2.0f;
    private float MaxVerticalRotationX = 20.0f;
    private float MinVerticalRotationX = -12.0f;
    Vector3 NewRotation;
    public Transform ObjectToRotate;

    // Use this for initialization
    void Start () {
        //Cursor.visible = false;
        //rotationController = GetComponent<RotationController>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //ObjectToRotate.eulerAngles.x - v
        NewRotation = new Vector3(
            ObjectToRotate.eulerAngles.x,
            ObjectToRotate.eulerAngles.y + h,
            ObjectToRotate.eulerAngles.z
            );
        ObjectToRotate.eulerAngles = NewRotation;
        //Debug.Log(newRotation.x + v);

        NewRotation = Camera.main.transform.eulerAngles;

        if (NewRotation.x + v >= MinVerticalRotationX && NewRotation.x + v <= MaxVerticalRotationX)
        {
            NewRotation.x += v;
            //Debug.Log("never");
        }
        Camera.main.transform.eulerAngles = NewRotation;

        //rotationController.sendInput(h);
        //transform.Rotate(v, h, 0);
        /*
        if (Input.GetAxis("Mouse Y") < 0)
        {
            input = "DOWN";
            rotationController.sendInput(input);
            return;
        }
        else if (Input.GetAxis("Mouse Y") > 0)
        {
            input = "UP";
            rotationController.sendInput(input);
            return;
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            input = "LEFT";
            rotationController.sendInput(input);
            return;
        }
        else if (Input.GetAxis("Mouse X") > 0)
        {
            input = "RIGHT";
            rotationController.sendInput(input);
            return;
        }
        */
    }

    private void Log(string text)
    {
        Debug.Log(text);
    }
}

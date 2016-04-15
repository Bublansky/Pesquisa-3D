using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    //private RotationController rotationController;
    private string input;
    private float horizontalSpeed = 2.0f;
    private float verticalSpeed = 2.0f;
    Vector3 newRotation;

    // Use this for initialization
    void Start () {
        //Cursor.visible = false;
        //rotationController = GetComponent<RotationController>();
	}
	
	// Update is called once per frame
	void Update () {

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        newRotation = new Vector3(
            Camera.main.transform.eulerAngles.x - v,
            Camera.main.transform.eulerAngles.y + h,
            Camera.main.transform.eulerAngles.z
            );
        Camera.main.transform.eulerAngles = newRotation;
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

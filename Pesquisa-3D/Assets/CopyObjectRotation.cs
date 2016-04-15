using UnityEngine;
using System.Collections;

public class CopyObjectRotation : MonoBehaviour {

    public GameObject ObjectToCopyRotation;
    private float x, y, z;
    private Vector3 newRotation;
    private float interval = 0.2f;
	// Use this for initialization
	void Start () {
       
        x = ObjectToCopyRotation.transform.eulerAngles.x;
        y = ObjectToCopyRotation.transform.eulerAngles.y;
        z = ObjectToCopyRotation.transform.eulerAngles.z;
        //InvokeRepeating("Update2", 0, interval);
    }
	
	// Update is called once per frame
	void Update2 () {
        
        newRotation = new Vector3(
            x + ObjectToCopyRotation.transform.eulerAngles.x,
            y + ObjectToCopyRotation.transform.eulerAngles.y,
            z + ObjectToCopyRotation.transform.eulerAngles.z
            );

        this.transform.eulerAngles = newRotation;
        //Debug.Log("eoq");
    }
}

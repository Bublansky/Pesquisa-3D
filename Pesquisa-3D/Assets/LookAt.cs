using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

    public Transform LookAtTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(
            new Vector3(
                LookAtTarget.position.x,
                0,
                LookAtTarget.position.z));
	}
}

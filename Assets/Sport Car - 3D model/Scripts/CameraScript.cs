using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    
    private bool MouseClick = false;
    public float cameraRotateSpeed = 5f;
    public Transform RotateTarget;
    public Transform transformObject; // Position of the object (The car in this case)
    private Vector3 distance;
    private float smooth = 0.5f;

    void Start () {
        distance = transform.position - transformObject.position;
    }
	
	// Update is called once per frame
	void Update () {
        //Rotation
        if (Input.GetMouseButtonDown(0)) MouseClick = true;
        if (Input.GetMouseButtonUp(0)) MouseClick = false;

        if(MouseClick) transform.RotateAround(RotateTarget.position, RotateTarget.up, Input.GetAxis("Mouse X") * cameraRotateSpeed);
        Vector3 newPosition = transformObject.position + distance;
        transform.position = Vector3.Slerp(transform.position, newPosition, smooth);
    }
}

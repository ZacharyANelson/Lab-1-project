using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private float speed;
    public Rigidbody rbCap;
    private bool start;
    public Transform car;
    // Start is called before the first frame update
    void Start()
    {
       
        speed = 20f;
        start = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Finish")
        {
            transform.position = new Vector3(50.38f, 16.59f, 203.05f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((speed * Input.GetAxis("Horizontal") * Time.deltaTime), 0f, (speed * Input.GetAxis("Vertical") * Time.deltaTime));
        if (Input.GetMouseButtonDown(1))
        {
            speed=50f;
        }
        if (Input.GetMouseButtonUp(1))
        {
            speed = 20f;
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0,-1, 0);
        }
    }
}

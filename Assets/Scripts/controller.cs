using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private float speed;
    public Rigidbody rbCap;
    private bool start;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((speed * Input.GetAxis("Horizontal") * Time.deltaTime), 0f, (speed * Input.GetAxis("Vertical") * Time.deltaTime));
        if (Input.GetMouseButton(0))
        {
            rbCap.AddForce(0, 40, 0);
        }
    }
}

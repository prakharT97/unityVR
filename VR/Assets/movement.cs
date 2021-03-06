using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{

    public float speed = 2f;

    public Rigidbody rb;
    float moveFB;
    float moveLR;


    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }


    void Update()
    {

        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;

        Vector3 movement = new Vector3(moveLR, 0, moveFB) * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }
}
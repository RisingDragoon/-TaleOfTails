using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private float horizontalSpeed = 40.0f;
    private float verticalSpeed = 40.0f;
    private float movementSpeed = 5f;
    public Transform cameraTransform;
    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        //transform.forward = GameObject.Find("MainCamera").transform.forward;
        //cameraTransform.LookAt(transform);
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.M))
        {
            Cursor.visible = !Cursor.visible;
        }
        float h = horizontalSpeed * Input.GetAxis("Mouse Y");
        float v = verticalSpeed * Input.GetAxis("Mouse X");
        //cameraTransform.Rotate(0, v * Time.deltaTime * movementSpeed, 0);
        if (Input.GetKey(KeyCode.W))
        {
            rb.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.position += -transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.position += -transform.right * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.position += transform.right * Time.deltaTime * movementSpeed;
        }
    }
    //void FixedUpdate()
    //{
    //    //Store input axes
    //    float lh = Input.GetAxisRaw("Horizontal");
    //    float lv = Input.GetAxisRaw("Vertical");

    //    Move(lh, lv);

    //    //Animating(lh, lv);
    //}

    //void Move(float lh, float lv)
    //{
    //    //Move the player
    //    Vector3 movement=new Vector3();
    //    movement.Set(lh, 0f, lv);

    //    movement = movement.normalized * 5 * Time.deltaTime;

    //    rb.MovePosition(transform.position + movement);

    //    if (lh != 0f || lv != 0f)
    //    {
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 5 * 2 * Time.deltaTime);
    //        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    //        //targetRotation = transform.rotation;
    //    }
    //}
}

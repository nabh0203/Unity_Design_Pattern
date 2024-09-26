using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Player : MonoBehaviour
{
    Camera cam;
    Rigidbody _rigidbody;
    Vector3 playerVelocity;

    float moveSpeed = 5;
    float jumpForce = 2f;
    float gravityValue = 9.81f;
    float sensitivity = 1; 
    float rotAroundX, rotAroundY;

    bool isGrounded;

    void Start()
    {
        cam = Camera.main;
        _rigidbody = GetComponent<Rigidbody>();
        rotAroundX = transform.eulerAngles.x;
        rotAroundY = transform.eulerAngles.y;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Move();

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        rotAroundX += Input.GetAxis("Mouse Y") * sensitivity;
        rotAroundY += Input.GetAxis("Mouse X") * sensitivity;

        rotAroundX = Mathf.Clamp(rotAroundX, -60, 60);
        transform.parent.rotation = Quaternion.Euler(0, rotAroundY, 0); 
        cam.transform.rotation = Quaternion.Euler(-rotAroundX, rotAroundY, 0);
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveVec = transform.forward * v + transform.right * h;
        moveVec.Normalize();
        moveVec *= moveSpeed;

        Vector3 newVelocity = _rigidbody.velocity;
        newVelocity.x = moveVec.x;
        newVelocity.z = moveVec.z;
        _rigidbody.velocity = newVelocity;
    }

    private void FixedUpdate()
    {
        isGrounded = IsGrounded();
    }

    private bool IsGrounded()
    {
        float extraHeightTest = 0.1f;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 2f + extraHeightTest))
        {
            return true;
        }
        return false;
    }
}
[Serializable]
public class PalyerMotion : MonoBehaviour
{

    public IMotion currentMotion { get; private set; }
    [SerializeField] RunMotion runMotion;
    [SerializeField] StopMotion stopMotion;
    [SerializeField] AttackMotion attackMotion;

    public void MotionStart(IMotion startingMotion)
    {
        currentMotion = startingMotion;
        startingMotion.Enter();
    }
    public void Update()
    {
        if (currentMotion != null)
        {
            currentMotion.Update();
        }
    }
    public void MotionStop(IMotion nextMotion)
    {
        currentMotion = nextMotion;
        nextMotion.Exit();
    }
}

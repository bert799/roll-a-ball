using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    private Rigidbody rb;
    private float x = 0.0f;
    private float z = 0.0f;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        x = input.x;
        z = input.y;
    }

    private void FixedUpdate() {
        // Atualizar o ridigbody
        rb.AddForce(x*speed, 0.0f, z*speed);
    }
}

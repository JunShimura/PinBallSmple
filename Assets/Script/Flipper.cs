using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float moveAngle = -45.0f;
    public KeyCode keyCode = KeyCode.A;
    bool isKeyDown = false;
    float baseAngle = 0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        baseAngle = transform.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        isKeyDown = Input.GetKey(keyCode);
    }
    private void FixedUpdate()
    {
        if (isKeyDown)
        {
            rb.MoveRotation(Quaternion.Euler(0, baseAngle + moveAngle, 0));
        }
        else
        {
            rb.MoveRotation(Quaternion.Euler(0, baseAngle, 0));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    Rigidbody rb;
    public

    float speed = 1 / 1000;
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.MovePosition(Vector3.right*speed * Time.deltaTime);
    }


}

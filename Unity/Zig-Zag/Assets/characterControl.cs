using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    Rigidbody rb;
    bool GoingRight = true;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.transform.position += transform.forward * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

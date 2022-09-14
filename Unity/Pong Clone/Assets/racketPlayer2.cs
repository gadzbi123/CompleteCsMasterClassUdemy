using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketPlayer2 : MonoBehaviour
{
    public float movementSpeed;
    public void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody>().velocity = new Vector3(0, -v) * movementSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketPlayer1 : MonoBehaviour
{
    public float movementSpeed;
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector3(0, v) * movementSpeed;
    }

}

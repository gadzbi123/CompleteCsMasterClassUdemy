using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketPlayer2 : MonoBehaviour
{
    public float movementSpeed;
    public GameObject ball;

    // For 1v1 with Player
    //public void FixedUpdate()
    //{
    //    float v = Input.GetAxisRaw("Vertical2");
    //    GetComponent<Rigidbody>().velocity = new Vector3(0, -v) * movementSpeed;
    //}

    //PC vs Player
    public void FixedUpdate()
    {
        float y = ball.transform.position.y;
        float wantedY = y;//+ Random.Range(0, racketHeight);
        float currentPos = gameObject.transform.position.y;
        if (Mathf.Abs(wantedY - currentPos) > 1 + Random.Range(0, 1.5f))
        {
            Rigidbody rigidbody = this.gameObject.GetComponent<Rigidbody>();
            if (wantedY - currentPos > 0)
                rigidbody.velocity = new Vector3(0, movementSpeed);
            else
                rigidbody.velocity = new Vector3(0, -movementSpeed);

        }
    }
}

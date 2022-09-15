using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public ballBehaviour ballMov;
    public void BounceFromRacket(Collision c)
    {
        Vector3 ballPos = this.transform.position;
        Vector3 racketPos = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "RacketP1")
            x = 1;
        else
            x = -1;
        float y = (ballPos.y - racketPos.y) / racketHeight;
        this.ballMov.IcreaseHitCounter();
        this.ballMov.MoveBall(new Vector3(x, y));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "RacketP1" || collision.gameObject.name == "RacketP2")
            this.BounceFromRacket(collision);

    }
}

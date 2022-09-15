using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviour : MonoBehaviour
{
    public float movSpeed = 5f;
    public float extraSpeedPerHit = 0.5f;
    public float maxExtraSpeed = 9;

    int hitCounter = 0;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        StartCoroutine(this.StartBall());
    }

    private void ResetBall()
    {
        transform.position = startPos;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0);
    }

    public IEnumerator StartBall(bool isStartingPlayer = true)
    {
        this.ResetBall();
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer)
            this.MoveBall(new Vector3(-1, 0));
        else
            this.MoveBall(new Vector3(1, 0));

    }
    public void MoveBall(Vector3 dir)
    {
        dir = dir.normalized;
        float speed = this.movSpeed + extraSpeedPerHit * hitCounter;
        Rigidbody rigidbody = this.gameObject.GetComponent<Rigidbody>();
        rigidbody.velocity = dir * speed;
    }

    public void IcreaseHitCounter()
    {
        if (this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed)
            this.hitCounter++;
    }
}

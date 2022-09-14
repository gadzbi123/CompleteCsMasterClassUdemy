using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviour : MonoBehaviour
{
    public float movSpeed = 5f;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitCounter = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer = true)
    {
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
        float speed = this.movSpeed + extraSpeedPerHit * this.extraSpeedPerHit;
        Rigidbody rigidbody = this.gameObject.GetComponent<Rigidbody>();
        rigidbody.velocity = dir * speed;
    }

    public void IcreaseHitCounter()
    {
        if (this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed)
            this.hitCounter++;
    }

    // Update is called once per frame
    void Update()
    {
        float moveVerical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, moveVerical, 0f);
        ;
    }
}

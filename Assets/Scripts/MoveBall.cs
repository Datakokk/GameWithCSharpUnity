using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speedMovement;
    public float extraSpeedHit;
    public float extraMaxSpeed;

    int hitCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartTheBall());
    }

    public IEnumerator StartTheBall(bool playerStart1 = true)
    {
        this.PositioningBall(playerStart1);

        this.hitCounter = 0;

        yield return new WaitForSeconds(2);
        if(playerStart1 )
        {
            this.movingTheBall(new Vector2(-1, 0));
        }
        else
        {
            this.movingTheBall(new Vector2(1, 0));

        }
    }

    public void PositioningBall(bool startPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (startPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }

    public void movingTheBall(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.speedMovement + this.hitCounter * this.extraSpeedHit;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();  

        rigidbody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter()
    {
        if(this.speedMovement * this.extraSpeedHit <= this.extraMaxSpeed)
        {
            this.hitCounter++;  
        }
    }
}

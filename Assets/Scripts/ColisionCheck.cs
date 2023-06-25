using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionCheck : MonoBehaviour
{
    public MoveBall moveBall;
    public ControlScore controScore;
   public void RacketRebound(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;
        float racketHeight = c.collider.bounds.size.y;

        float x = (c.gameObject.name == "Racket1") ? 1 : -1;

        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        this.moveBall.IncreaseHitCounter();
        this.moveBall.movingTheBall(new Vector2 (x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket1" ||  collision.gameObject.name == "Racket2")
        {
            this.RacketRebound(collision);
        }
        else if( collision.gameObject.name == "WallLeft")
        {
            this.controScore.GoalPlayer2();
            StartCoroutine(this.moveBall.StartTheBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            this.controScore.GoalPlayer1();
            StartCoroutine(this.moveBall.StartTheBall(false));

        }
    }
}

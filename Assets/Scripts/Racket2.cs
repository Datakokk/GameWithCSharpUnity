using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket2 : MonoBehaviour
{
    public float speedMovement;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speedMovement;
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0 )//eger saga yani computer paddle'a dogru gidiyorsa
        {
            if (ball.position.y > rb.position.y)//topun yuksekligi paddledan yuksekse.
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if (ball.position.y < rb.position.y)//tam tersi
            {
                rb.AddForce(Vector2.down * speed);
            }

        }
        else
        {
            if (rb.position.y > 0f) //merkez noktasi sifir // saga tarafta oldugunu gosterir
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (rb.position.y < 0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}

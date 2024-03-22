
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>(); // carptigi andaki topun bilgilerini alir.

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal; //ilk carptigi andaki normal konum. (normal = dýþarýya donuk olan vektor.)
            ball.AddForce(-normal * bounceStrength); //sekmesi icin ve sektikten sonraki gucu ayarlamak icin
        }
    }
}

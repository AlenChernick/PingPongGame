using UnityEngine;

public class RacketEnemeyAI : MonoBehaviour
{
    public float movementSpeed;

    public GameObject ball;

    private void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.y - ball.transform.position.y) > 50)
            if (ball.transform.position.y > transform.position.y)
                GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 1) * movementSpeed;
            else
                GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -1) * movementSpeed;
        else
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);

    }
}

using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitCounter = 0;

    void Start()
    {
        StartCoroutine(StartBallMovement());
    }

    void PositionBall(bool isStartingPlayer)
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);


        if (isStartingPlayer)
            gameObject.transform.position = new Vector3(-100, 0, 0);
        else
            gameObject.transform.position = new Vector3(100, 0, 0);
    }

    public IEnumerator StartBallMovement(bool isStartingPlayer = true)
    {
        PositionBall(isStartingPlayer);

        hitCounter = 0;

        yield return new WaitForSeconds(2);

        if (isStartingPlayer)
            MoveBall(new Vector2(-1, 0));
        else
            MoveBall(new Vector2(1, 0));
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float speed = movementSpeed + hitCounter * extraSpeedPerHit;

        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.linearVelocity = direction * speed;
    }

    public void IncreaseHitCounter()
    {
        if (hitCounter * extraSpeedPerHit <= maxExtraSpeed)
            hitCounter++;
    }
}

using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPostiton = collision.gameObject.transform.position;

        float racketHight = collision.collider.bounds.size.y;

        float x;

        if (collision.gameObject.name == "Player") x = 1;
        else x = -1;

        float y = (ballPosition.y - racketPostiton.y) / racketHight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Enemy")
            BounceFromRacket(collision);
        else if (collision.gameObject.name == "WallLeft")
        {
            scoreController.GoalEnemy();
            StartCoroutine(ballMovement.StartBallMovement(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            scoreController.GoalPlayer();
            StartCoroutine(ballMovement.StartBallMovement(false));
        }
    }
}

using UnityEngine;

public class RacketEnemy : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, vertical) * movementSpeed;
    }
}

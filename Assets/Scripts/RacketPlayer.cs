using UnityEngine;

public class RacketPlayer : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, vertical) * movementSpeed;
    }
}

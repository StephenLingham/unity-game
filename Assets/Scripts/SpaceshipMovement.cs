using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = moveSpeed * Time.deltaTime * new Vector3(moveHorizontal, moveVertical, 0f);

        transform.position += movement;
    }
}

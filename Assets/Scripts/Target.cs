using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float speed = 2f;
    private int dir = 1;

    void Update()
    {
        transform.Translate(Vector3.right * dir * speed * Time.deltaTime);

        if (transform.position.x > 5f || transform.position.x < -5f)
            dir *= -1;
    }
}

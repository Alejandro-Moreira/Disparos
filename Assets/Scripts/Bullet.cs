using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 3f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si toca algo con tag "Target", destruye ambos
        if (collision.gameObject.CompareTag("Target"))
        {
            FindObjectOfType<GameManager>()?.AddScore(100);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

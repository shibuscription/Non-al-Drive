using UnityEngine;

public class CanMover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // ‰æ–ÊŠO‚Éo‚½‚çÁ‚·
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}

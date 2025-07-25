using UnityEngine;

public class CanMover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // 画面外に出たら消す
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}

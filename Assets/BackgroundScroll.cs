using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float resetPosition = 20f; // �摜�̕�
    public float startPosition = 20f;

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x <= -resetPosition)
        {
            Vector2 newPos = new Vector2(startPosition, transform.position.y);
            transform.position = newPos;
        }
    }
}

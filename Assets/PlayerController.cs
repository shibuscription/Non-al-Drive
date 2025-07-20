using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float[] lanesY = { 2f, 0f, -2f };
    private int currentLane = 1; // Å‰‚Í^‚ñ’†

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentLane > 0)
        {
            currentLane--;
            UpdatePosition();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && currentLane < lanesY.Length - 1)
        {
            currentLane++;
            UpdatePosition();
        }
    }

    void UpdatePosition()
    {
        Vector3 pos = transform.position;
        pos.y = lanesY[currentLane];
        transform.position = pos;
    }
}

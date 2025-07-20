using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float[] lanesY = { 2f, 0f, -2f };
    private int currentLane = 1; // 最初は真ん中
    public ThirstManager thirstManager;

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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OKCan"))
        {
            Debug.Log("OK缶に当たった！");
            Destroy(other.gameObject);
            thirstManager.AddThirst(0.2f); // のどゲージ回復
        }
        else if (other.CompareTag("NGCan"))
        {
            Debug.Log("NG缶に当たった！ 飲酒運転で捕まった！");
            Destroy(other.gameObject);
            // ゲームオーバー処理をここに書く
        }
    }

}

using UnityEngine;
using UnityEngine.UI;

public class ThirstManager : MonoBehaviour
{
    public Image thirstBar;

    private float thirst = 1.0f; // 100%スタート

    void Update()
    {
        // 時間経過で少しずつ減少
        thirst -= Time.deltaTime * 0.05f;
        thirst = Mathf.Clamp01(thirst);

        // ゲージに反映
        thirstBar.fillAmount = thirst;

        // 色変更（緑→黄→赤）
        if (thirst > 0.6f)
        {
            thirstBar.color = Color.green;
        }
        else if (thirst > 0.3f)
        {
            thirstBar.color = Color.yellow;
        }
        else
        {
            thirstBar.color = Color.red;
        }

        // ゲームオーバー判定
        if (thirst <= 0f)
        {
            Debug.Log("ゲームオーバー！");
            // ここにゲームオーバー処理を書く（例：シーン遷移、停止など）
        }
    }

    // 外部から呼び出して回復できるように
    public void AddThirst(float amount)
    {
        thirst += amount;
        thirst = Mathf.Clamp01(thirst);
    }
}

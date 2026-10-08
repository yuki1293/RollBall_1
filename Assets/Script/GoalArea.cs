using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public GameObject goalCanvas;

    private void Start()
    {
        goalCanvas.SetActive(false);
    }

    // IsTriggerが設定されているオブジェクトに付いていると
    // コライダーとの接触判定を行ってくれる関数
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag　== "Player")
        {
            Debug.Log("ゴールしたよ！");
            goalCanvas.SetActive(true);
        }
    }
}
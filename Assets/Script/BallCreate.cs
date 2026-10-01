using UnityEngine;

public class BallCreate : MonoBehaviour
{
   
    public GameObject ballPrefab;
    //ballPrefab=何を生成するか
    void Start()
    {
        Instantiate(ballPrefab, transform.position, Quaternion.identity);
        //transform.position=どこに生成するか
        //Quaternion.identity=回転なし

    }
}
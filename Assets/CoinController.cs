using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // 回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        // 回転(カリキュラムでは「0,3,0」だが回転速度が早すぎたので1に変更）
        this.transform.Rotate(0, 1, 0);

    }
}

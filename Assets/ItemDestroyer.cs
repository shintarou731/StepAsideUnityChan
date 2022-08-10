using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    // unityちゃんのオブジェクト
    private GameObject unitychan;

    // unityちゃんとアイテムデストロイヤーの差
    private float difference = 10f;




    // Start is called before the first frame update
    void Start()
    {
        // unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        // ユニティちゃんの後方を追従
        this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.unitychan.transform.position.z - this.difference);
    }

    // 触れたCar,Cone,Coinを消す
    private void OnTriggerEnter(Collider other)
    {

        if ((other.gameObject.tag == "CarTag") || (other.gameObject.tag == "TrafficConeTag") || (other.gameObject.tag == "CoinTag"))
        {
            Destroy(other.gameObject);
            Debug.Log("" + other.gameObject + "を消去した");
        }
    }
}

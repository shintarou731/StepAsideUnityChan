using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    // carPrefabを入れる
    public GameObject carPrefab;

    // coinPrefabを入れる
    public GameObject coinPrefab;

    // ConePrefabを入れる
    public GameObject conePrefab;

    // unityちゃんが到達するとアイテムが生成される
    private float startPos = 30f;

    // ゴール地点
    private float goalPos = 360f;

    // アイテムを出すx方向の範囲
    private float posRange = 3.4f;

    // unityちゃんのオブジェクト
    private GameObject unitychan;

    // アイテムが生成される間隔
    public float item_interval = 15f;

    // unityちゃんとアイテム生成地点の距離
    private float itemPos = 60f;


    // Start is called before the first frame update
    void Start()
    {
        // unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {
        // unityちゃんのz方向の現在地
        float unitychan_z = this.unitychan.transform.position.z;



        // unityちゃんの距離に応じてアイテムを生成
        if (unitychan_z > startPos　&& goalPos > unitychan_z + itemPos)
        {
            // アイテム生成に必要な次の到達地点を設定
            startPos += item_interval;

            // どの位置にアイテムを出すのかランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                // コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan_z + itemPos);
                }
            }
            else
            {

                // レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    // アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    // アイテムを置くz座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    // 60%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        // コインを生成
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan_z + itemPos + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        // 車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan_z + itemPos + offsetZ);
                    }
                }
            }

        }
    }
}

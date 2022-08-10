using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    // unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    // unity�����ƃA�C�e���f�X�g���C���[�̍�
    private float difference = 10f;




    // Start is called before the first frame update
    void Start()
    {
        // unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        // ���j�e�B�����̌����Ǐ]
        this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.unitychan.transform.position.z - this.difference);
    }

    // �G�ꂽCar,Cone,Coin������
    private void OnTriggerEnter(Collider other)
    {

        if ((other.gameObject.tag == "CarTag") || (other.gameObject.tag == "TrafficConeTag") || (other.gameObject.tag == "CoinTag"))
        {
            Destroy(other.gameObject);
            Debug.Log("" + other.gameObject + "����������");
        }
    }
}

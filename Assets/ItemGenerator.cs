using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    // carPrefab������
    public GameObject carPrefab;

    // coinPrefab������
    public GameObject coinPrefab;

    // ConePrefab������
    public GameObject conePrefab;

    // unity����񂪓��B����ƃA�C�e�������������
    private float startPos = 30f;

    // �S�[���n�_
    private float goalPos = 360f;

    // �A�C�e�����o��x�����͈̔�
    private float posRange = 3.4f;

    // unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    // �A�C�e�������������Ԋu
    public float item_interval = 15f;

    // unity�����ƃA�C�e�������n�_�̋���
    private float itemPos = 60f;


    // Start is called before the first frame update
    void Start()
    {
        // unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {
        // unity������z�����̌��ݒn
        float unitychan_z = this.unitychan.transform.position.z;



        // unity�����̋����ɉ����ăA�C�e���𐶐�
        if (unitychan_z > startPos�@&& goalPos > unitychan_z + itemPos)
        {
            // �A�C�e�������ɕK�v�Ȏ��̓��B�n�_��ݒ�
            startPos += item_interval;

            // �ǂ̈ʒu�ɃA�C�e�����o���̂������_���ɐݒ�
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                // �R�[����x�������Ɉ꒼���ɐ���
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan_z + itemPos);
                }
            }
            else
            {

                // ���[�����ƂɃA�C�e���𐶐�
                for (int j = -1; j <= 1; j++)
                {
                    // �A�C�e���̎�ނ����߂�
                    int item = Random.Range(1, 11);
                    // �A�C�e����u��z���W�̃I�t�Z�b�g�������_���ɐݒ�
                    int offsetZ = Random.Range(-5, 6);
                    // 60%�R�C���z�u:30%�Ԕz�u:10%�����Ȃ�
                    if (1 <= item && item <= 6)
                    {
                        // �R�C���𐶐�
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan_z + itemPos + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        // �Ԃ𐶐�
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan_z + itemPos + offsetZ);
                    }
                }
            }

        }
    }
}

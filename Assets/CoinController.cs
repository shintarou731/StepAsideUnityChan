using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // ��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        // ��](�J���L�������ł́u0,3,0�v������]���x�����������̂�1�ɕύX�j
        this.transform.Rotate(0, 1, 0);

    }
}

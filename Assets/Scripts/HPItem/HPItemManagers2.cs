using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItemManagers2 : MonoBehaviour
{
    // ��������v���n�u�i�[�p
    public GameObject PrefabHPItem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ��莞�Ԃ��ƂɃv���n�u�𐶐�
        if (Time.frameCount % 70 == 0)
        {
            // �����ʒu
            Vector3 pos = new Vector3(15.0f, 1.0f, 30.0f);
            // �v���n�u���w��ʒu�ɐ���
            Instantiate(PrefabHPItem, pos, Quaternion.identity);
        }
    }
}
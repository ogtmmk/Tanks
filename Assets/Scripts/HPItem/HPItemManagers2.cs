using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItemManagers2 : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabHPItem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 一定時間ごとにプレハブを生成
        if (Time.frameCount % 70 == 0)
        {
            // 生成位置
            Vector3 pos = new Vector3(15.0f, 1.0f, 30.0f);
            // プレハブを指定位置に生成
            Instantiate(PrefabHPItem, pos, Quaternion.identity);
        }
    }
}
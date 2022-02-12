using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour
{
    // プレハブ格納用
    public GameObject EnemyPrefab;

    void Start()
    {
        // プレハブを元にオブジェクトを生成する
        GameObject instance = (GameObject)Instantiate(EnemyPrefab, new Vector3(4.0f, 0.0f, -25.0f), Quaternion.Euler(0, 290, 0));
    }

 }
    

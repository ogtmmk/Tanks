using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager1 : MonoBehaviour
{
    // プレハブ格納用
    public GameObject EnemyPrefab;

    void Start()
    {
        // プレハブを元にオブジェクトを生成する
        GameObject instance = (GameObject)Instantiate(EnemyPrefab, new Vector3(-23.0f, 0.0f, 24.0f), Quaternion.Euler(0, 110, 0));
    }

 }
    

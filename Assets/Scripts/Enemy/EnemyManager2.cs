using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour
{
    // �v���n�u�i�[�p
    public GameObject EnemyPrefab;

    void Start()
    {
        // �v���n�u�����ɃI�u�W�F�N�g�𐶐�����
        GameObject instance = (GameObject)Instantiate(EnemyPrefab, new Vector3(4.0f, 0.0f, -25.0f), Quaternion.Euler(0, 290, 0));
    }

 }
    

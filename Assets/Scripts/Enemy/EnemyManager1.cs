using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager1 : MonoBehaviour
{
    // �v���n�u�i�[�p
    public GameObject EnemyPrefab;

    void Start()
    {
        // �v���n�u�����ɃI�u�W�F�N�g�𐶐�����
        GameObject instance = (GameObject)Instantiate(EnemyPrefab, new Vector3(-23.0f, 0.0f, 24.0f), Quaternion.Euler(0, 110, 0));
    }

 }
    

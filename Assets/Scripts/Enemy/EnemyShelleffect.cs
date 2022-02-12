using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShelleffect : MonoBehaviour

{
    // エフェクトプレハブのデータを入れるための箱を作る。
    [SerializeField]
    private GameObject effectPrefab;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        
        {

            // エフェクトを実体化する
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            // エフェクトを2秒後に画面から消す
            Destroy(effect, 2.0f);
        }
    }
}

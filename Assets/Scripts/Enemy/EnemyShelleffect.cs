using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShelleffect : MonoBehaviour

{
    // �G�t�F�N�g�v���n�u�̃f�[�^�����邽�߂̔������B
    [SerializeField]
    private GameObject effectPrefab;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        
        {

            // �G�t�F�N�g�����̉�����
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            // �G�t�F�N�g��2�b��ɉ�ʂ������
            Destroy(effect, 2.0f);
        }
    }
}

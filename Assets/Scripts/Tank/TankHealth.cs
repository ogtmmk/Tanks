using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public float m_StartingHealth = 100f;
    const float MAX = 100;
    public Slider m_Slider;
    public Image m_FillImage;
    public Color m_FullHealthColor = Color.green;
    public Color m_ZeroHealthColor = Color.red;
    public GameObject m_ExplosionPrefab;
    

    private AudioSource m_ExplosionAudio;
    private ParticleSystem m_ExplosionParticles;
    private float m_CurrentHealth;
    private bool m_Dead;


    private void Awake()
    {
        m_ExplosionParticles = Instantiate(m_ExplosionPrefab).GetComponent<ParticleSystem>();
        m_ExplosionAudio = m_ExplosionParticles.GetComponent<AudioSource>();

        m_ExplosionParticles.gameObject.SetActive(false);
    }


    private void OnEnable()
    {
        m_CurrentHealth = m_StartingHealth;
        m_Dead = false;

        SetHealthUI();
    }


    public void TakeDamage(float amount)
    {
        // Adjust the tank's current health, update the UI based on the new health and check whether or not the tank is dead.
        //タンクの現在の状態を調整し、新しいヘルスに基づいてUIを更新し、タンクが死んでいるかどうかを確認します。
        m_CurrentHealth -= amount;

        SetHealthUI();

        if (m_CurrentHealth <= 0f && !m_Dead)
        {
            OnDeath();
        }

    }


    private void SetHealthUI()
    {
        // Adjust the value and colour of the slider.
        //スライダーの値と色を調整します。
        m_Slider.value = m_CurrentHealth;

        m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
    }


    private void OnDeath()
    {
        // Play the effects for the death of the tank and deactivate it.
        //タンクの死のための効果を再生し、それを無効にします。
        m_Dead = true;

        m_ExplosionParticles.transform.position = transform.position;
        m_ExplosionParticles.gameObject.SetActive(true);

        m_ExplosionParticles.Play();

        m_ExplosionAudio.Play();

        gameObject.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        // ぶつかったオブジェクトが回復アイテムだった場合
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // その収集アイテムを非表示にする
            other.gameObject.SetActive(false);

            //体力を30回復
            m_CurrentHealth = m_CurrentHealth + 30;

            // 最大値を超えたら最大値を渡す
            m_CurrentHealth = System.Math.Min(m_CurrentHealth, MAX);
            
            //スライダーの値と色を調整
            m_Slider.value = m_CurrentHealth;

            m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
            
        }
    }

    void OnCollisionEnter(Collision other)
    {
        // "EnemyShell"に当たった場合
        if (other.gameObject.CompareTag("EnemyShell"))
        {

            // "EnemyShell"を非表示にする
            other.gameObject.SetActive(false);

            //ダメージ10
            m_CurrentHealth = m_CurrentHealth - 10;

            //スライダーの値と色を調整
            m_Slider.value = m_CurrentHealth;

            m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);

        }
    }
}
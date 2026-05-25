using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Slider realHP;
    public Slider ghostHP;

    public float maxHP = 20f;
    private float currentHP;

    public float ghostSpeed = 5f;

    void Start()
    {
        currentHP = maxHP;

        realHP.maxValue = maxHP;
        ghostHP.maxValue = maxHP;

        realHP.value = maxHP;
        ghostHP.value = maxHP;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        currentHP = Mathf.Clamp(currentHP, 0, maxHP);

        realHP.value = currentHP;
    }

    void Update()
    {
        ghostHP.value = Mathf.Lerp(
            ghostHP.value,
            realHP.value,
            Time.deltaTime * ghostSpeed
        );
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;

    public HPBar hpBar;

    public void TakeDamage(float amount)
    {
        Debug.Log("Player took damage");

        health -= amount;

        hpBar.TakeDamage(amount);

        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage(5);
            }
        }
    }
    }
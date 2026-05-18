using UnityEngine;

public class WinSystem : MonoBehaviour
{
    public GameObject winUI;
    public BaseTurret[] turrets;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (var turret in turrets)
            {
                turret.enabled = false;
            }

            winUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
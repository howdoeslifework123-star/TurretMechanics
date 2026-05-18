using UnityEngine;

public class SlayerTurret : BaseTurret
{
    public int pelletCount = 6;
    public float spreadAngle = 20f;
    public float fireRate = 1.5f;
    private float timer;

    protected override void Attack()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            for (int i = 0; i < pelletCount; i++)
            {
                Vector3 spread = Quaternion.Euler(
                    Random.Range(-spreadAngle, spreadAngle),
                    Random.Range(-spreadAngle, spreadAngle),
                    0) * transform.forward;

                RaycastHit hit;
                if (Physics.Raycast(transform.position, spread, out hit, range))
                {
                    if (hit.transform.CompareTag("Player"))
                    {
                        hit.transform.GetComponent<PlayerHealth>().TakeDamage(10f);
                    }
                }
            }

            timer = 0f;
        }
    }
}
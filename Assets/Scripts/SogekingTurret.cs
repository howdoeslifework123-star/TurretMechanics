using UnityEngine;

public class SogekingTurret : BaseTurret
{
    public float fireRate = 1f;
    private float timer;

    protected override void Attack()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            RaycastHit hit;
            Vector3 dir = (target.position - transform.position).normalized;

            if (Physics.Raycast(transform.position, dir, out hit, range))
            {
                if (hit.transform.CompareTag("Player"))
                {
                    hit.transform.GetComponent<PlayerHealth>().TakeDamage(25f);
                }
            }

            timer = 0f;
        }
    }
}
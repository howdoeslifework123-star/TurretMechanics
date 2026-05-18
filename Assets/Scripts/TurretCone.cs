using UnityEngine;

public class TurretCone : BaseTurret
{
    public float coneAngle = 45f;
    public float damageRate = 10f;

    protected override void Attack()
    {
        Vector3 dirToTarget = (target.position - transform.position).normalized;
        float angle = Vector3.Angle(transform.forward, dirToTarget);

        if (angle < coneAngle)
        {
            PlayerHealth player = target.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage(damageRate * Time.deltaTime);
            }
        }
    }
}
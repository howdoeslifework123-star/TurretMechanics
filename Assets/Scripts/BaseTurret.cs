using UnityEngine;

public abstract class BaseTurret : MonoBehaviour
{
    public float range = 10f;
    public Transform target;

    protected virtual void Update()
    {
        FindTarget();
        if (target != null)
        {
            Attack();
        }
        transform.LookAt(target);
    }

    void FindTarget()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            float dist = Vector3.Distance(transform.position, player.transform.position);
            if (dist <= range)
                target = player.transform;
            else
                target = null;
        }
    }

    protected abstract void Attack();
}
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Transform quad_p0, quad_p1, quad_p2;
    public Transform cubic_p0, cubic_p1, cubic_p2, cubic_p3;

    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnQuadratic), 1f, spawnInterval);
        InvokeRepeating(nameof(SpawnCubic), 2f, spawnInterval);
    }

    void SpawnQuadratic()
    {
        GameObject e = Instantiate(enemyPrefab, quad_p0.position, Quaternion.identity);

        var mover = e.AddComponent<QuadraticBezier>();
        mover.p0 = quad_p0;
        mover.p1 = quad_p1;
        mover.p2 = quad_p2;
    }

    void SpawnCubic()
    {
        GameObject e = Instantiate(enemyPrefab, cubic_p0.position, Quaternion.identity);

        var mover = e.AddComponent<CubicBezier>();
        mover.p0 = cubic_p0;
        mover.p1 = cubic_p1;
        mover.p2 = cubic_p2;
        mover.p3 = cubic_p3;
    }
}
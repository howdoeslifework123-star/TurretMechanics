using UnityEngine;

public class CubicBezier : MonoBehaviour
{
    public Transform p0, p1, p2, p3;

    public float speed = 1f;
    private float t = 0f;

    void Update()
    {
        t += Time.deltaTime * speed;

        Vector3 pos =
            Mathf.Pow(1 - t, 3) * p0.position +
            3 * Mathf.Pow(1 - t, 2) * t * p1.position +
            3 * (1 - t) * Mathf.Pow(t, 2) * p2.position +
            Mathf.Pow(t, 3) * p3.position;

        transform.position = pos;

        if (t >= 1f)
        {
            Destroy(gameObject);
        }
    }
}
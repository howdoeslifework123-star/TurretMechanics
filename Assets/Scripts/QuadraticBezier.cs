using UnityEngine;

public class QuadraticBezier : MonoBehaviour
{
    public Transform p0; 
    public Transform p1; 
    public Transform p2; 

    public float speed = 1f;
    private float t = 0f;

    void Update()
    {
        t += Time.deltaTime * speed;

        Vector3 pos = Mathf.Pow(1 - t, 2) * p0.position +
                      2 * (1 - t) * t * p1.position +
                      Mathf.Pow(t, 2) * p2.position;

        transform.position = pos;

        if (t >= 1f)
        {
            Destroy(gameObject); 
        }
    }
}
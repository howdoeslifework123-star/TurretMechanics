using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRendering : MonoBehaviour
{
    public float range = 10f;
    public int segments = 50;

    void Start()
    {
        LineRenderer lr = GetComponent<LineRenderer>();
        lr.positionCount = segments + 1;

        for (int i = 0; i <= segments; i++)
        {
            float angle = i * 2 * Mathf.PI / segments;
            float x = Mathf.Cos(angle) * range;
            float z = Mathf.Sin(angle) * range;

            lr.SetPosition(i, new Vector3(x, 0, z));
        }
    }
}
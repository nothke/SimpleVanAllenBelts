#if UNITY_EDITOR

using UnityEngine;

public class SDFDrawer : MonoBehaviour
{
    public ToroidalBeltData data;

    [Range(4, 64)]
    public int volumeDensity = 32;
    public float dataScale = 1;

    public bool slice;
    public int sliceX;

    public Color color;
    public float lineScale = 0.1f;

    private void OnDrawGizmos()
    {
        if (data == null) return;

        Vector3 scale = Vector3.one * lineScale;

        int half = volumeDensity / 2;

        Vector3 offset = transform.position;
        Vector3 tScale = transform.localScale / volumeDensity;

        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
        Gizmos.color = color;

        for (int x = -half; x < half; x++)
        {
            if (slice)
                if (sliceX != x) continue;

            for (int y = -half; y < half; y++)
            {
                for (int z = -half; z < half; z++)
                {
                    Vector3 pos = new Vector3(x, y, z) * data.scaleMult;

                    pos = (offset + Vector3.Scale(pos, tScale)) * dataScale;

                    float v = data.Sample(pos);

                    if (v <= 0) continue;

                    pos = pos / dataScale;

                    Gizmos.DrawLine(pos, (pos + scale * v));
                }
            }
        }
    }
}
#endif
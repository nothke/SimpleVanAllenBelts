using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Belt", menuName = "Orbital/Toroidal Belt Data")]
public class ToroidalBeltData : ScriptableObject
{
    // Data
    public float scaleMult = 1f;
    public ToroidalBelt[] belts;

    // Methods

    /// <summary>
    /// Get value from position
    /// </summary>
    /// <param name="scaledPosition">Sampling position. Use value * scaleMult, you probably want to use a double for that.</param>
    /// <returns></returns>
    public float Sample(Vector3 scaledPosition)
    {
        float v = 0;
        for (int i = 0; i < belts.Length; i++)
        {
            float a = SFTorusNoV(scaledPosition, belts[i].r1, belts[i].r2, belts[i].stretch);
            float b = SFTorusNoV(scaledPosition, belts[i].in_r1, belts[i].in_r2, belts[i].in_stretch);
            v = Mathf.Max(v, -Mathf.Max(a, -b));
        }

        if (v < 0) v = 0;

        return v;
    }

    // From https://iquilezles.org/www/articles/distfunctions/distfunctions.htm by Inigo Quilez
    float SDFTorus(Vector3 p, float r1, float r2, float stretch)
    {
        Vector2 p_xz = new Vector2(p.x * stretch, p.z * stretch);
        Vector2 q = new Vector2(p_xz.magnitude - r1, p.y);
        return q.magnitude - r2;
    }

    // Slightly faster. Bypasses vectors and calculates magnitudes directly
    float SFTorusNoV(Vector3 p, float r1, float r2, float stretch)
    {
        float px = p.x * stretch;
        float pz = p.z * stretch;
        float pxz_l = Mathf.Sqrt(px * px + pz * pz);

        float qx = pxz_l - r1;
        float qy = p.y;
        float q_l = Mathf.Sqrt(qx * qx + qy * qy);
        return q_l - r2;
    }
}

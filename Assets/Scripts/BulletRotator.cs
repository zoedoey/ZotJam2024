using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BulletRotator
{
    public static Vector2 RotatedBy(this Vector2 spinningpoint, float degrees, Vector2 center = default(Vector2))
    {
        degrees *= Mathf.Deg2Rad;
        float xMult = Mathf.Cos(degrees);
        float yMult = Mathf.Sin(degrees);
        Vector2 toSpin = spinningpoint - center;
        Vector2 result = center;
        result.x += toSpin.x * xMult - toSpin.y * yMult;
        result.y += toSpin.x * yMult + toSpin.y * xMult;
        return result;
    }
}

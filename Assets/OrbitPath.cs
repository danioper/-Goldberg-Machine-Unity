using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OrbitPath
{
    public float yAxis;
    public float xAxis;

    public OrbitPath(float yAxis, float xAxis)
    {
        this.yAxis = yAxis;
        this.xAxis = xAxis;
    }
    public Vector2 Evaluate(float t)
    {
        float angle = Mathf.Deg2Rad * t * 360;
        float x = Mathf.Sin(angle) * xAxis;
        float y = Mathf.Cos(angle) * yAxis;
        return new Vector2(x, y);
    }
}

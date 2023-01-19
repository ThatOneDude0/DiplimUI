using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " New ButtonScaleChanger", menuName = "Scale Changer", order = 51)]
public class ScaleData : ScriptableObject
{
    public Vector3 _baseScale;
    public Vector3 _enterScale;
    public Vector3 _clickScale;
}

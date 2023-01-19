using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " New ButtonColorChanger", menuName = "Color Changer", order = 51)]
public class ColorData : ScriptableObject
{
    public Color _baseColor;
    public Color _enterColor;
    public Color _clickColor;
}

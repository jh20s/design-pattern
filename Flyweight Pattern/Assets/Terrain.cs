using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain
{
    public bool isWater = false;
    public int moveCost = 0;
    public string objectName = "";

    public Terrain(bool _isWater, int _moveCost, string _objectName)
    {
        isWater = _isWater;
        moveCost = moveCost;
        objectName = _objectName;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoiseSettings
{
    // values to change the Noise
    public float strength = 1.0f;
    [Range(1,8)]
    public int numLayers = 1;
    public float baseRoughness = 1.0f;
    public float roughness = 2.0f;
    public float persistence = 0.5f;
    public Vector3 centre;
    public float minValue;
}

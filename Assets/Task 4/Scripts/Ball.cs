using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public BallType BallType;
    [SerializeField] private Material[] _colors;
    [SerializeField] private MeshRenderer _renderer;

    private void OnValidate()
    {
        _renderer.material = _colors[(int)BallType];
    }
}
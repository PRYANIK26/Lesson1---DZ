using System;
using UnityEngine;

[Serializable]
public class GunConfig
{
    [SerializeField] private int _patronsCount;
    [SerializeField] private int _patronsPerShot;
    [SerializeField] private int _bulletSpeed;
    [SerializeField] private Bullet _bulletPrefab;
    
    public int PatronsCount => _patronsCount;
    public int PatronsPerShot => _patronsPerShot;
    public int BulletSpeed => _bulletSpeed;
    public Bullet BulletPrefab => _bulletPrefab;
}
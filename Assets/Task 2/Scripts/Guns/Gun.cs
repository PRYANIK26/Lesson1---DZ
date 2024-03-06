using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    protected GunConfig GunConfig;
    protected int Patrons;
    
    [SerializeField] private Transform _bulletSpawnPoint;
    
    private Bullet _bulletPrefab;


    public void Initialize(GunConfig gunConfig)
    {
        GunConfig = gunConfig;
        
        Patrons = GunConfig.PatronsCount;
        _bulletPrefab = GunConfig.BulletPrefab;
    }

    public virtual void Shot()
    {
    }

    protected void AddBullet()
    {
        Vector3 position = _bulletSpawnPoint.position;

        for (int i = 0; i < GunConfig.PatronsPerShot; i++)
        {
            Instantiate(_bulletPrefab, position, Quaternion.identity).SetupBullet(GunConfig.BulletSpeed, _bulletSpawnPoint);
            position += Vector3.right * 0.2f;
        }
    }
}

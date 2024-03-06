using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    public void SetupBullet(int speed, Transform spawnPoint)
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(spawnPoint.forward * speed);
        Destroy(gameObject, 5f);
    }
}

using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _forceValue;
    [SerializeField] private float _damage;
    Enemy enemy;

    private Rigidbody _rigidbody;
    private AttackState _attackState;
    private RaycastHit _hit;
    private Vector3 _direction;
    public float Damage => _damage;

    private void Start()
    {
        _attackState = FindObjectOfType<AttackState>();
        _rigidbody = GetComponent<Rigidbody>();
        _hit = _attackState.GetHitPoint();
        _direction = _hit.point - transform.position;
        _rigidbody.AddForce(_direction.normalized * _forceValue);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.root.TryGetComponent(out IDamageable hit))
        {
            hit.TakeDamage(_damage, collision.collider);
        }

        Destroy(gameObject);
    }
}

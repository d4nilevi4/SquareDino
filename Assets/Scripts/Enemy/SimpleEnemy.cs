using UnityEngine;

public class SimpleEnemy : Enemy, IDamageable
{
    [SerializeField] private Collider _head;
    [SerializeField] private float _headshotDamageMultiplier;

    private RagdollControl _ragdollControl;

    public float Health { get; set; }

    private void Start()
    {
        _ragdollControl = GetComponent<RagdollControl>();
        Health = health;
        healthBar.SetMaxHealth(Health);
    }

    public void TakeDamage(float damageValue, Collider collider)
    {
        if (collider == _head)
        {
            Health -= damageValue * _headshotDamageMultiplier;
        } else
        {
            Health -= damageValue;
        }

        healthBar.SetHealth(Health);
        
        if (Health <= 0)
        {
            EnemyDie();
        }
    }

    protected override void EnemyDie()
    {
        isDie = true;
        _ragdollControl.MakePhysical();
    }
}

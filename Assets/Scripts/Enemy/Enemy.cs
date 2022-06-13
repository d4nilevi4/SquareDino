using UnityEngine;

public abstract class Enemy : MonoBehaviour
{ 
    [SerializeField] protected float health;
    [SerializeField] protected EnemyHealthBar healthBar;

    protected bool isDie;

    public bool IsDie => isDie;

    protected abstract void EnemyDie();
}

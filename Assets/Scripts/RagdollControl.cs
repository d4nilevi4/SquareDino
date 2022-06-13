using UnityEngine;

public class RagdollControl : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _allRigidbodies;
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();

        foreach (var rigidbody in _allRigidbodies)
            rigidbody.isKinematic = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            MakePhysical();
        }
    }

    public void MakePhysical()
    {
        _animator.enabled = false;
        foreach (var rigidbody in _allRigidbodies)
            rigidbody.isKinematic = false;
    }
}

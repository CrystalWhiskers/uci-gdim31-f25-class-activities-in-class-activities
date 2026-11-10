using UnityEngine;

// Write the BatW6 class here.

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;

    private bool _isChasing;
    [SerializeField] private Transform _target;

    /*
    private void Start()
    {
        StartChasing(_target);
    }
    */

    public void StartChasing(Transform target)
    {
        _target = target;
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }

    private void Update()
    {
        if (_isChasing == false || _target == null)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}

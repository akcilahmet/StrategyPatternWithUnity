using UnityEngine;

/// <summary>
/// A component that destroys the GameObject it is attached to after a specified time.
/// </summary>
public class ObjectDestructor : MonoBehaviour
{
    private float _destroyTime;

    /// <summary>
    /// Initializes the destructor with a specified time and starts the countdown to destroy the GameObject.
    /// </summary>
    public void Initialize(float destroyTime)
    {
        _destroyTime = destroyTime;
        Invoke(nameof(DestroySelf), _destroyTime);
    }

    /// <summary>
    /// Destroys the GameObject this component is attached to.
    /// </summary>
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
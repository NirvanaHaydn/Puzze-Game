using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed, lifeTime;

    private void Start()
    {
        Invoke("Die", lifeTime);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            return;
        }
        else
        {
            Die();
        }
    }
}

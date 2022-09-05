using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("ScenaryBorder"))
        {
            Destroy(gameObject);
        }
    }
}

using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField]private GameObject box;
    [SerializeField]private Vector3 spawnPoint;
    private GameObject currentBox;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            if(currentBox != null)
            {
                Destroy(currentBox);
            }
            currentBox = Instantiate(box, spawnPoint, transform.rotation);
        }
    }
}

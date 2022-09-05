using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private KeyCode trigger;
    [SerializeField] private GameObject bullet;
    private GameObject currentBullet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(trigger))
        {
            currentBullet = Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}

using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private KeyCode trigger;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Animator playerAnimator;
    private GameObject currentBullet;

    private void Update()
    {
        if(playerAnimator.GetBool("isShooting") == true)
        {
            playerAnimator.SetBool("isShooting", false);
        }

        if(Input.GetKeyDown(trigger))
        {
            playerAnimator.SetBool("isShooting", true);
            currentBullet = Instantiate(bullet, transform.position, transform.rotation);
        }
        
    }
}

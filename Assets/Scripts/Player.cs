using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private float speed, jumpForce;
    [SerializeField] private KeyCode[] inputKeys;
    [SerializeField] private Animator playerAnimator;
    private bool canJump = true;
    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        InvokeRepeating("IdleAnimation", 0.0f, 15.0f);
    }

    private void Update()
    {
        PlayerControls();
    }

    private void IdleAnimation()
    {
        playerAnimator.SetBool("canDoIdle", true);
    }

    private void PlayerControls()
    {
        Vector3 dir = Vector3.zero;

        if(Input.GetKey(inputKeys[0]))
        {
            playerAnimator.SetBool("isMoving", true);
            dir += Vector3.forward;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(inputKeys[1]))
        {
            playerAnimator.SetBool("isMoving", true);
            dir += Vector3.left;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        if (Input.GetKey(inputKeys[2]))
        {
            playerAnimator.SetBool("isMoving", true);
            dir += Vector3.back;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey(inputKeys[3]))
        {
            playerAnimator.SetBool("isMoving", true);
            dir += Vector3.right;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(inputKeys[4]) && canJump == true)
        {
            playerAnimator.SetBool("isJumping", true);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        }

        transform.position += dir * speed * Time.deltaTime;
        if(dir == Vector3.zero)
        {
            playerAnimator.SetBool("isMoving", false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            playerAnimator.SetBool("isJumping", false);
            canJump = true;
        }

        if(other.gameObject.CompareTag("ScenaryBorder"))
        {
            transform.position = new Vector3(0, 2, 0);
        }
    }
}

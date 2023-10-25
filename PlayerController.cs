using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private float moveSpeed = 5.0f; //이동 속도

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0.0f).normalized;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (moveDirection != Vector3.zero)
        {
            // 움직임 애니메이션 재생
            animator.SetBool("IsMoving", true);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
        else
        {
            // idle 애니메이션 재생
            animator.SetBool("IsMoving", false);
        }
    }
}

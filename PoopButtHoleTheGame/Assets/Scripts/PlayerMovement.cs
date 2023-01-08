using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private Animator player;
    private Rigidbody2D playerRigidbody;
    private Vector3 change;
    private bool isFacingRight = true;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ChangeSetup();
        if (change != Vector3.zero)
        {
            MoveCharacter();
            player.SetFloat("Speed", 1);
        }
        else player.SetFloat("Speed", 0);
    }

    void ChangeSetup()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
    }

    void MoveCharacter()
    {
        playerRigidbody.MovePosition(transform.position + change.normalized * speed * Time.fixedDeltaTime);
        FlipCheck();
    }

    private void FlipCheck()
    {
        if (isFacingRight && change.x > 0) Flip();
        else if (!isFacingRight && change.x < 0) Flip();;
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        this.transform.Rotate(Vector2.up * 180);
    }
}

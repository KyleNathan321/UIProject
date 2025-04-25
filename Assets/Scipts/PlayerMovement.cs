using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

 //   public int scoreCount;
   // public ScoreManager sm;
    // I apparently dont need to delcare the 2 variables above
    public AudioSource audioPlayer;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Animator animator;
    public Rigidbody2D rb;
    public Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        float horizontal = context.ReadValue<Vector2>().x;
        float vertical = context.ReadValue<Vector2>().y;
        moveInput = context.ReadValue<Vector2>();
        if (horizontal != 0|| vertical != 0){
            animator.SetBool("isRunning", true);
        }
        else{
            animator.SetBool("isRunning", false);
       }
 }

 void OnTriggerEnter2D(Collider2D other)
 {
    if (other.gameObject.CompareTag("Collectible"))
    {
Destroy(other.gameObject);
ScoreManager.Instance.scoreCount++;
audioPlayer.Play();
    }
 }

}


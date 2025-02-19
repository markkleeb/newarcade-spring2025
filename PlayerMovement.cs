using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    private Vector2 movement;
    public float speed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Hz", movement.x);
        animator.SetFloat("Vt", movement.y);

        transform.Translate(movement * speed * Time.deltaTime);
        
    }
}

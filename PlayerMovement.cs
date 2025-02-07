using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode jump;

    public float jumpForce = 10.0f;
    public float speed = 20.0f;

    private Rigidbody2D theresaRB;
    private SpriteRenderer theresaSR;
    private bool facingLeft = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theresaSR = gameObject.GetComponent<SpriteRenderer>();
        theresaRB = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()

    {

        Debug.Log(facingLeft);
       // if (Input.GetKey(moveLeft))
       if(Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.left * Time.deltaTime* speed);
            facingLeft = true;
        }

        //if (Input.GetKey(moveRight))
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * Time.deltaTime* speed);
            facingLeft = false;
        }

        if (Input.GetKeyDown(jump))
        {
            theresaRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (facingLeft)
        {
            theresaSR.flipX = false;
        }
        else
        {
            theresaSR.flipX = true;
        }


        


    }
}

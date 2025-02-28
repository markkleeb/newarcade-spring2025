using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed = 10.0f;

    private GameManager gm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);
        
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Invader")
        {
            gm.AddScore();
            Destroy(collider.gameObject);
            Destroy(gameObject);
            //Nothing happens after this
        }
    }
}

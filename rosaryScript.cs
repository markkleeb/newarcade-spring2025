using UnityEngine;

public class rosaryScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            //play a sound
            //add to score
            Destroy(gameObject);
            //I am dead, nothing will happen after this
        }
        
    }
}

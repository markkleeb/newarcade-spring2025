using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rosary;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(rosary, new Vector2(Random.Range(-10, 10), Random.Range(-4, 4)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

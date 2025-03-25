using UnityEngine;

public class BallController : MonoBehaviour
{
    public float vel = 3;
    public Vector2 spawnPosition = new Vector2(-1, 2);

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        respawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void respawnBall()
    {
        transform.position = spawnPosition;

    }
}

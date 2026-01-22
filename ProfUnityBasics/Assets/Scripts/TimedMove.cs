using UnityEngine;

public class TimedMove : MonoBehaviour
{
    public Vector3 dir;
    public float speed;

    private float timeLeftToMove;
    public float moveTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLeftToMove = moveTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeftToMove -= Time.deltaTime;
        Vector3 frameStep = dir * Time.deltaTime * speed;
        Vector3 temp = transform.position + frameStep;
        if(timeLeftToMove > 0)
        {
            transform.position = temp;
        }
        else
        {
            timeLeftToMove = moveTime;
            // reverse direction
            dir = -1 * dir;
        }        
    }
}

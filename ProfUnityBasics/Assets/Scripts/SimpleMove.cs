using System.Linq;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public Vector3 dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 frameStep = dir * Time.deltaTime;
        Vector3 temp = transform.position + frameStep;
        if(temp.y > -1 && temp.y < 3)
        {
            transform.position = temp;
        }
        else
        {
            // reverse direction
            dir = -1 * dir;
        }
    }
}

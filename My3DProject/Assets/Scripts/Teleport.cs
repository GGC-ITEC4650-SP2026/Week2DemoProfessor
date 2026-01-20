using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 v = new Vector3(0, 3, 0);
        transform.position = transform.position + v;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

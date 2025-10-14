using UnityEngine;

public class patternmovement : MonoBehaviour
{
    private float speed = 8f;
    

    // Update is called once per frame
    void Update()
    {
        //this //
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

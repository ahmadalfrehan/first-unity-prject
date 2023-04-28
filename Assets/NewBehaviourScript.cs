
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        
        rb.AddForce(0,200,500);
    }

    void Update()
    { 
        
        rb.AddForce(0,0,200*Time.deltaTime);
    }
}
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public float FallingTime;

    private TargetJoint2D target;

    
    
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {   
            Invoke("Falling", FallingTime);
            Invoke("disapear",FallingTime += 0.3f);
             

            
        }
        
        
       
       
        
    }
    
    void Falling()
    {
        target.enabled = false;
       
        
    }
    void disapear()
    {
         Destroy(gameObject, 0.5f);
    }
}
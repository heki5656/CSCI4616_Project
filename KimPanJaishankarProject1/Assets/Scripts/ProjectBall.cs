using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectBall : MonoBehaviour
{
    
    // public float thrust = 10f;
    public Rigidbody rb;

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        Invoke("FixedUpdate", 10); //2 is the time
    }
    
    void FixedUpdate() 
    {
        // Invoke("newVoid", 2);
        rb.AddForce(40,0,10, ForceMode.Impulse);
        
    }



    // Rigidbody m_Rigidbody;
    // public float m_Thrust = 20f;

    // void Start()
    // {
    //     m_Rigidbody =  GetComponent<Rigidbody>();
    //     m_Rigidbody.AddForce(m_Thrust);
    // //     GameObject m_Rigidbody = new GameObject();
    // //     m_Rigidbody.name = "bullet";
    // //     m_Rigidbody.AddComponent<Rigidbody>();
    // //     m_Rigidbody.AddForce(transform.up * m_Thrust);
    // }


}

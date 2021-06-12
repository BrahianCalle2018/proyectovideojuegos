using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    public GameObject sonidoE;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D c1)
    {
     if(c1.gameObject.tag == "Piso")
        {
            Instantiate(sonidoE);
            Destroy(this.gameObject);
        }   
     if(c1.gameObject.tag == "Bala")
        {
            Instantiate(sonidoE);
            Destroy(this.gameObject);
            Destroy(c1.gameObject);
        }
    }
}

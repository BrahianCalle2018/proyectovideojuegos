using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float TiempoDeVida = 3;
    public GameObject efecto;
    public ContactPoint2D contacto;
    public Quaternion rot;
    public Vector3 pos;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoDeVida -= Time.deltaTime;
        if (TiempoDeVida <= 0)
        {
            Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y,
                this.transform.position.z), transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D c1)
    {
        if (c1.gameObject.tag != "Piso")
        {
            contacto = c1.contacts[0];
            rot = Quaternion.FromToRotation(Vector3.up, contacto.normal);
            pos = contacto.point;
            Instantiate(efecto, pos, rot);
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaSonido : MonoBehaviour
{
    public float TiempoV = 2;
    public GameObject sonido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoV -= Time.deltaTime;
        if (TiempoV <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

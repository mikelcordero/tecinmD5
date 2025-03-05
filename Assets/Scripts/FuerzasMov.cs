using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzasMov : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float movHorinzontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 moviemiento = new Vector3 (movHorinzontal, 0.0f,movVertical);

        this.GetComponent<Rigidbody>().AddForce(moviemiento * velocidad);
    }
}

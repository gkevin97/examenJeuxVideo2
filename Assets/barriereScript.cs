using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barriereScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Explo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Ennemie")
        {
            Instantiate(Explo, transform.position, Quaternion.identity);
        }
            
    }
}

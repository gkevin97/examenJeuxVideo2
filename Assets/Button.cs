using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public Transform background;
    public Transform mur1;
    public Transform mur2;
    public Transform mur3;
    public Transform mur4;
    public TMP_Text Textcount;
    public TMP_Text TextExplosion;


    int count = 0;





    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            count += 1;
        }
        Textcount.text = "x " + count.ToString();

    }




    public void explosion()
    {
        background.GetComponent<SpriteRenderer>().color = Color.red;
        mur1.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        mur2.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        mur3.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        mur4.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        mur1.GetComponent<Rigidbody2D>().AddForce(mur1.position, ForceMode2D.Impulse);
        mur2.GetComponent<Rigidbody2D>().AddForce(mur2.position, ForceMode2D.Impulse);
        mur3.GetComponent<Rigidbody2D>().AddForce(mur3.position, ForceMode2D.Impulse);
        mur4.GetComponent<Rigidbody2D>().AddForce(mur4.position, ForceMode2D.Impulse);

        TextExplosion.text = "Je m’excuse…";


    }



}

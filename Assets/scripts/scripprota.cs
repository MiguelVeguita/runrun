using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripprota : MonoBehaviour
{
    private Rigidbody2D _comporig;
    public int velocidad;
    private float hori, verti;
    private Animator _anim;
    private SpriteRenderer _sprit;
    public GameObject disparo;

    private void Awake()
    {
        _comporig = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sprit = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        caminata();
        tiro();
       

    }
    private void FixedUpdate()
    {
        _comporig.velocity = new Vector2(hori * velocidad, 0 );
       
    }
    public void caminata()
    {
        hori = Input.GetAxis("Horizontal");
        verti = Input.GetAxis("Vertical");

        if (hori < 0)
        {
            _sprit.flipX = true;
            _anim.SetBool("run", false);
            if (Input.GetKeyDown("space") == true)
            {
                Instantiate(disparo, transform.position, transform.rotation);
            }
        }
        else if (hori > 0)
        {
            _sprit.flipX = false;
            _anim.SetBool("run", false);
            if (Input.GetKeyDown("space") == true)
            {
                Instantiate(disparo, transform.position, transform.rotation);
            }
        }
        else
        {
            _anim.SetBool("run", true);

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
     
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (verti > 0)
        {
            if (collision.gameObject.tag == "piso")
            {
                print("ddddd");
                this.transform.position = new Vector2(transform.position.x, 0.28f);
            }
        }
    }
    public void tiro()
    {
       
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripbala : MonoBehaviour
{
    public SpriteRenderer personaje;
    public float hori,balavelo,direc;

    // Start is called before the first frame update
     void Awake()
    {
        personaje = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        hori = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        
      if(hori<0)
         {
            direc = -1;

         }
        else 
         {
            direc = 1;
         }
        transform.position = new Vector2(transform.position.x + direc*balavelo * Time.deltaTime, transform.position.y);
    }
}

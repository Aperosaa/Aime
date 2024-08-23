using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bİrds : MonoBehaviour
{
    public Rigidbody2D myrg;
    void Start()
    {
    GetComponent<Rigidbody2D>().isKinematic = true;
    }

     private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color=Color.black;
    }
    void Update()
    {
        
    }
}
 
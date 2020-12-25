using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Değişkenler
    public float speed;
    private void Start() 
    {
        Destroy(gameObject,4);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}

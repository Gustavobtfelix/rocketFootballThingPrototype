using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D jogador;
    public bool grounded;
    public float speed;
    public float jumpForce;

    void Update()
    {
        if(grounded){
            jogador.velocity = Vector2.right * Input.GetAxis("Horizontal") * speed;
            if(Input.GetKey(KeyCode.Space))
            jogador.velocity = Vector2.up * jumpForce;
        }
        if(Input.GetKey(KeyCode.A))
            jogador.rotation += 1;
        
        if(Input.GetKey(KeyCode.D))
            jogador.rotation -= 1;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("ground"))
            grounded = true;
        
        
    }
}

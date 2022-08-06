using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject); 
        Debug.Log("1");
    }
}

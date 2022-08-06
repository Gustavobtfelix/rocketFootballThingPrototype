using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gol : MonoBehaviour
{
    public Transform go;
    private void OnTriggerEnter2D(Collider2D other) {
        Instantiate(other.gameObject, go.position, go.rotation);
        Destroy(other.gameObject);
        Debug.Log("1");
    }
}

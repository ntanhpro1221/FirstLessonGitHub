using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float       jumpForce = 5;
    [SerializeField] private GameObject  prefab;
    
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = new Vector2(0, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("SBlock")) {
            // Debug.Log("Detected colliding with a flat at " + DateTime.Now.TimeOfDay);
            Instantiate(prefab, Vector3.zero, Quaternion.identity);
        }
    }
}

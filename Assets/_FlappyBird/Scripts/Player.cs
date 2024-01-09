using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using Unity.Mathematics;
using UnityEditor.UIElements;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float       speed     = 5;
    [SerializeField] private float       jumpForce = 20;
    [SerializeField] private float       cooldown;
    [SerializeField] private float       deltaTimeShoot = 0.5f;
    
    // Start is called before the first frame update
    void Start() {
        cooldown    = deltaTimeShoot;
        
    }
    
    // Update is called once per frame
    void Update() {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        
       ShootingHandle(); 
    }

    void ShootingHandle() {
        cooldown -= Time.deltaTime;
        // rb.velocity = new Vector2(speed, rb.velocity.y);
        if (cooldown <= 0) {
            cooldown = deltaTimeShoot;
            PoolingManager.Instance.GetObject(NamePrefabPool.Bullet, null, transform.position).Disable(1.5f);
        }
    }
    // private void OnCollisionEnter2D(Collision2D other) {
    //     if (other.gameObject.CompareTag("SBlock")) {
    //         Debug.Log("Detected colliding with a flat at " + DateTime.Now.TimeOfDay);
    //     }
    // }
}

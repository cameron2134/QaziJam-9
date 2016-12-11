﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {




    private void Die() {

        
        Destroy(this.gameObject);

    }


	// Use this for initialization
	void Start () {
      
        Invoke("Die", 2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}



   void OnCollisionEnter2D(Collision2D other) {
        
        Die();
    }


    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Portal") 
            other.GetComponent<Portal>().PortalTank(this.gameObject);

        
    }

}

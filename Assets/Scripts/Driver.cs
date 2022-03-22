using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        float xAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xAmount, 0, 0);
        transform.Translate(0, yAmount, 0);

    }
        void OnCollisionEnter2D(Collision2D other) {
                Debug.Log("Ouch!");
                moveSpeed = slowSpeed;
        }

        void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Boost"){
                Debug.Log("Boost!");
                moveSpeed = boostSpeed;
            }

        
        }
}

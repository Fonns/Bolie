using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controlo : MonoBehaviour {
    public float velocidade;
    private Rigidbody cr;

    void Start()
    {
        cr = GetComponent<Rigidbody>();


    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        cr.AddForce(movement * velocidade);
    }
}
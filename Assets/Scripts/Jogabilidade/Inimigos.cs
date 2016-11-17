using UnityEngine;
using System.Collections;

public class Inimigos : MonoBehaviour {

    public Transform jogador;
    float velIni = 20;
    
	void Start () {
        jogador = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update () {
        transform.LookAt(jogador);
        transform.position += transform.forward*velIni*Time.deltaTime;
    }
}

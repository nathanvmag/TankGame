using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody2D rb;
    public float speed;
	// Use this for initialization
	void Start () {
        Destroy(this, 1);
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.up * speed;
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Animator>().Play("Explosion");      
        rb.simulated = false;
        StartCoroutine(destruir());
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        GetComponent<Animator>().Play("Explosion");       
        rb.simulated = false;
        StartCoroutine(destruir());

    }

    public IEnumerator destruir()
    {
        Debug.Log("aqui");
        yield return new WaitForSeconds(2);
        PhotonNetwork.Destroy(GetComponent<PhotonView>());
    }
}

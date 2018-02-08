using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour {
    public GameObject bullet;
	// Use this for initialization
	void Start () {
        StartCoroutine(lookat());
	}
	
	// Update is called once per frame
	void Update () {
       if (Input.GetMouseButtonDown(0))
        {
           Instantiate(bullet, transform.FindChild("Pfogo").transform.position, transform.rotation);
        }
    }
    IEnumerator lookat()
    {
        while (true)
        {
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            diff.Normalize();

            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
            yield return new WaitForSeconds(0.1f);
        }
    }
}

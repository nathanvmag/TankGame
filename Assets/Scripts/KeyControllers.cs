using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControllers : MonoBehaviour {
    public static KeyCode RightArrow, LeftArrow, Acelerate, Back, Shoot;
	// Use this for initializatio
	void Start () {
        DontDestroyOnLoad(gameObject);

        RightArrow = KeyCode.D;
        LeftArrow = KeyCode.A;
        Acelerate = KeyCode.W;
        Back = KeyCode.S;
	}
	
	// Update is called once per frame  
	void Update () {
		
	}
}

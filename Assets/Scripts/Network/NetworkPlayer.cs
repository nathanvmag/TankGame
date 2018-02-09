using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayer : MonoBehaviour {
   [SerializeField] private MonoBehaviour[] playersScripts;
    private PhotonView pview;

        
    // Use this for initialization
    void Start () {
        pview = GetComponent<PhotonView>();
        initialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void initialize()
    {
        if (pview.isMine)
        {

        }
        else
        {
            foreach (MonoBehaviour mb in playersScripts)
            {
                mb.enabled = false;
            }
        }
    }
}

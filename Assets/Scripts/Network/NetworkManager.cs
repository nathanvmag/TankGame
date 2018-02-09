using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NetworkManager :Photon.MonoBehaviour {
    private string GameVersion = "1";
    bool create = false;
    int roomcount = 0;
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject Lobbycamera;
	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings(GameVersion);
        
	}
	
	// Update is called once per frame
	void Update () {     
    

       GameObject.Find("ServerStatus").GetComponent<Text>().text = PhotonNetwork.connectionStateDetailed.ToString();
    }
    public void createrom()
    {
       
    }
    public virtual void OnJoinedLobby()
    {
        Debug.Log("WE ARE CONNECTED");
        PhotonNetwork.JoinOrCreateRoom("1", null, null);
    }
    public virtual void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(Player.name, transform.position, Quaternion.identity, 0);
      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " time since Host requested");
        StartHost();
    }
    
	// Use this for initialization
	void Start () {
	}
	
 	// Update is called once per frame
	void Update () {
		
	}

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " time since Host started");
    }

    public override void OnStartClient(NetworkClient myclient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " time since client start Requested");
        InvokeRepeating("PrintDotUntilConnect", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        //base.OnClientConnect(conn);
        Debug.Log(Time.timeSinceLevelLoad + " Client is connect to IP: " + conn.address);
        CancelInvoke();
    }

    private void PrintDotUntilConnect()
    {
        Debug.Log(".");
    }

}

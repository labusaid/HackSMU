﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhotonPlayer : MonoBehaviour {

    private PhotonView PV;
    public GameObject myAvatar;

	// Use this for initialization
	void Start () {
        PV = GetComponent<PhotonView>();
        if (PV.IsMine == true)
        {
            myAvatar = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerAvatar"), Vector3.zero, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

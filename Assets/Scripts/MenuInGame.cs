﻿using UnityEngine;
using System.Collections;

public class MenuInGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if( GUILayout.Button ("返回主菜单") ){
			Application.LoadLevel("menu");	//返回主菜单
			if(Network.peerType != NetworkPeerType.Disconnected ){//断开网络
				Network.Disconnect();
			}
		}
		GUILayout.Box ("可悔棋次数: " + GameManager.canBackSteps);
		if( GUILayout.Button ("我要反悔") ){
			SendMessage("Rollback");		//调用回退函数
		}
	}

}
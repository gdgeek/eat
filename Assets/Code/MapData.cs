﻿using UnityEngine;
using System.Collections;

public class MapData : IMapData {
	
	private bool pass_ = false;
	public MapData(bool pass){
		pass_ = pass;
	}
	 public bool pass(Vector2 from){
		return pass_;
	}

	 public void trample(){
		
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour {

    public List<CheckPoint> checkPoints;
    public CheckPoint currentCheckPoint;
	
	void Awake() {
		
	}
	
	public void OnCheckPointTriggered(CheckPoint newCheckPoint) {
        if (currentCheckPoint.id < newCheckPoint.id)
        {
            currentCheckPoint = newCheckPoint;
        }
	}
}

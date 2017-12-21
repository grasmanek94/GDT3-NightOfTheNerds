using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour {

    private List<CheckPoint> checkPoints; // All checkpoints you've passed. Should always start with startcheckpoint
    public CheckPoint startCheckPoint; // Required
    public CheckPoint currentCheckPoint; // Starts as startCheckPoint, after it changes
	
	void Awake() {
        checkPoints = new List<CheckPoint>();
        checkPoints.Add(startCheckPoint);
        currentCheckPoint = startCheckPoint;
	}
	
    /// <summary>
    /// This method sets the current checkpoint to the new checkpoint.
    /// Once the currentcheckpoint has changed, all previous triggered checkpoints should be disabled.
    /// </summary>
    /// <param name="newCheckPoint"></param>
	public void OnCheckPointTriggered(CheckPoint newCheckPoint) {
        currentCheckPoint = newCheckPoint;
        checkPoints.Add(currentCheckPoint);
        DisableCheckPoints(currentCheckPoint.id);
	}

    /// <summary>
    /// This method disables all the previously triggered checkpoints, which do not match the given checkpointId. 
    /// The sprite for each checkpoint should be changed accordingly.
    /// </summary>
    /// <param name="checkPointId">The current checkpoint id</param>
    private void DisableCheckPoints(int checkPointId)
    {
        foreach (CheckPoint chk in checkPoints)
        {
            if (!chk.id.Equals(checkPointId))
            {
                chk.active = false;
            }
            chk.SetSprite();
        }
    }
}

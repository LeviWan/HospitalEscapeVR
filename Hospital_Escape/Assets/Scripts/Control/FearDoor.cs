using UnityEngine;
using System.Collections;

public class FearDoor : OpenDoor {


	void Start () {
        LerpEulerAngels = -60f;
        base.BindEvent();
	}
	
	void Update () {
        LerpToOpenDoor();
       
	}
    protected override void LerpToOpenDoor()
    {
        base.LerpToOpenDoor();
    
    }
}

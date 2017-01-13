using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChestDoor : OpenDoor {


    public GameObject pswPanel;
    public GameObject player;
	void Start () {
        LerpEulerAngels = -45f;
        base.BindEvent();
	}
	
	void Update () {
        LerpToOpenDoor();
      
	}

    protected override void LerpToOpenDoor()
    {
        if (isOpenDoor)
        {
            //四元数插值
            Quaternion quaternion = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(new Vector3(LerpEulerAngels,0f , 0f)), 0.05f);
            this.transform.rotation = quaternion;
        }
    }

    public override void EnterState(UnityEngine.EventSystems.BaseEventData data)
    {
        base.EnterState(data);
        if (Vector3.Distance(this.transform.position,player.transform.position)<=5)
        {
            pswPanel.SetActive(true);
        }
      
    }

    public override void Open(UnityEngine.EventSystems.BaseEventData data)
    {
        if (GameManager.instance.isGetPasswordToOpenTheChest)
        {
            base.Open(data);
        }
       
    }
}

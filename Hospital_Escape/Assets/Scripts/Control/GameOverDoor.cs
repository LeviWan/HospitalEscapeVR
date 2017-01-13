using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameOverDoor : OpenDoor {

    public Text info;
    public Text info2;
    public GameObject player;
    public GameObject gameOverPanel;
	void Start () {
        LerpEulerAngels = 78f;
        base.BindEvent();
	}
	

	void Update () {
        LerpToOpenDoor();
	}

    protected override void LerpToOpenDoor()
    {
        
        base.LerpToOpenDoor();
    }

    public override void Open(BaseEventData data)
    {
        if (GameManager.instance.isGetKey)
        {
            base.Open(data);
            
            info2.gameObject.SetActive(false);
            PlayerMove.isOperate = true;
            gameOverPanel.SetActive(true);
           
        }
       
        
    }

    public override void EnterState(BaseEventData data)
    {
        base.EnterState(data);
        if (Vector3.Distance(this.transform.position, player.transform.position) <= 5)
        {
            if (GameManager.instance.isGetKey)
            {
                info2.gameObject.SetActive(true);
            }
            else
            info.gameObject.SetActive(true);
        }
        
    }

    public override void ExitState(BaseEventData data)
    {
        base.ExitState(data);
        info.gameObject.SetActive(false);
        info2.gameObject.SetActive(false);
    }
}

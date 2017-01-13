using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[RequireComponent(typeof(EventTrigger))]
public class OpenDoor : MonoBehaviour
{
    
    protected bool isOpenDoor = false;
    protected float LerpEulerAngels=78f;
    private EventTrigger eventTrigger;
    
  

    


    public virtual void Open(BaseEventData data)
    {
        isOpenDoor = true;

       

    }

    protected virtual void LerpToOpenDoor()
    {
        if (isOpenDoor)
        {
            //四元数插值
            Quaternion quaternion = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(new Vector3(0f, LerpEulerAngels, 0f)), 0.05f);
            this.transform.rotation = quaternion;
        }
    }

    public virtual void EnterState(BaseEventData data)
    {
        PlayerMove.isOperate = true;
    }

    public virtual void ExitState(BaseEventData data)
    {
        PlayerMove.isOperate = false;
    }

   protected virtual void BindEvent()
    {
        eventTrigger = this.GetComponent<EventTrigger>();
        EventTrigger.Entry GazeEnter = new EventTrigger.Entry();
        GazeEnter.eventID = EventTriggerType.PointerEnter;
        GazeEnter.callback = new EventTrigger.TriggerEvent();
        GazeEnter.callback.AddListener(EnterState);
        eventTrigger.triggers.Add(GazeEnter);



        EventTrigger.Entry GazeExit = new EventTrigger.Entry();
        GazeExit.eventID = EventTriggerType.PointerExit;
        GazeExit.callback = new EventTrigger.TriggerEvent();
        GazeExit.callback.AddListener(ExitState);
        eventTrigger.triggers.Add(GazeExit);

        EventTrigger.Entry GazeClick = new EventTrigger.Entry();
        GazeClick.eventID = EventTriggerType.PointerDown;
        GazeClick.callback = new EventTrigger.TriggerEvent();
        GazeClick.callback.AddListener(Open);
        eventTrigger.triggers.Add(GazeClick);



    }


}

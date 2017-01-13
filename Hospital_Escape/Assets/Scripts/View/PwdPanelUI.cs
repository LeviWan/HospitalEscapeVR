using UnityEngine;
using System.Collections;

public class PwdPanelUI : MonoBehaviour {
    public void GazeEnter()
    {
        PlayerMove.isOperate = true;
    }
    public void GazeExit()
    {
        PlayerMove.isOperate = false;
    }
}

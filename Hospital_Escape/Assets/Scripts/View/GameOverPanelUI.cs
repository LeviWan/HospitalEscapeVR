using UnityEngine;
using System.Collections;

public class GameOverPanelUI : MonoBehaviour {

    public void GazeEnter()
    {
        PlayerMove.isOperate = true;
    }

    public void GazeExit()
    {
        PlayerMove.isOperate = false;
    }
}

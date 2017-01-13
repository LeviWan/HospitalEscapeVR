using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public bool isGetPasswordToOpenTheChest = false;
    public bool isGetKey = false;

    void Awake()
    {
        instance = this;
        isGetPasswordToOpenTheChest = false;
        isGetKey = false;
    }
	
}

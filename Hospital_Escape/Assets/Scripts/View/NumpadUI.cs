using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class NumpadUI : MonoBehaviour {

    public InputField inputF;
	void Start () {
        BindOnClick();
	}


    public void BindOnClick()
    {
        foreach (Transform child in this.transform)
        {
            ButtonUI click = child.GetComponent<ButtonUI>();
            child.GetComponent<Button>().onClick.AddListener(click.ChangeValue);
 
        }
    }

   
}

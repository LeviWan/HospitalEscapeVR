using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResetUI : MonoBehaviour {

    public InputField inputF;

    

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ResetInputFValue);
    }
    public void ResetInputFValue()
    {
        inputF.text = "";
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour {

    public InputField inputF;
    public void ChangeValue()
    {

        if (inputF.text.Length < inputF.characterLimit)
        {
            inputF.text += this.gameObject.name;
        }
    }
}

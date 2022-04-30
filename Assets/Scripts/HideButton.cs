using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour
{
    public GameObject continueButton;

    public void HiddenButton(){
        continueButton.SetActive(false);
    }
}

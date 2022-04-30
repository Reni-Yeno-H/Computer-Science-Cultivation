using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string Url;
    public void OpenLink(){
        Application.OpenURL(Url);
    }
}

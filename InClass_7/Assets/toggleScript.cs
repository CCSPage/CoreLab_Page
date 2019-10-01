using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleScript : MonoBehaviour
{
    public GameObject heart;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = heart.GetComponent<Animator>();
    }
//public void OnToggle()
//    {
//        bool toggleVal = (GetComponent<Toggle>().isOn);
//      anim.SetBool(toggleVal);
//    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour
{
    public void OnValueChanged(float value)
    {
        Debug.Log("New Value " + value);
    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetPlayerName : MonoBehaviour
{
    public void SetPlayerNameMethod()
    {
        GameManager.Instance.SetPlayerName(GetComponent<InputField>().text);
    }
}
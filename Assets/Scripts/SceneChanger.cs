using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] int _sceneNumber = 0;
    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}

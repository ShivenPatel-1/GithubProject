using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause2 : MonoBehaviour
{
    public void Pause()
    {
        SceneManager.LoadScene("Pause2");
    }
}
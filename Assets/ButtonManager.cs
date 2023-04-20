using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OnButtonClicked(int LevelID)
    {
        switch (LevelID)
        {
            case 0:
                SceneManager.LoadScene("ImageDetection");
                break;
            case 1:
                SceneManager.LoadScene("PlaneDetection");
                break;
            default:
                break;
        }
    }
}

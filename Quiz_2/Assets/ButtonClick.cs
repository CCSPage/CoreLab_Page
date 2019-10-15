using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
 public void doThis()
    {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    SceneManager.LoadScene(currentSceneIndex + 1);
    }
}

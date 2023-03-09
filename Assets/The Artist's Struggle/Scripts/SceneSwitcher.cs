using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private float delay;
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void NextLevel(float waitTime)
    {
        delay = waitTime;
        StartCoroutine(NextLevelRoutine());
    }

    IEnumerator NextLevelRoutine()
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
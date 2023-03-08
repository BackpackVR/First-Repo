using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTimeChange : MonoBehaviour
{

    [SerializeField] private string leveltoLoad;
    [SerializeField] private float delaytimer = 10f;
      private float timeElapsed;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
    
    if (timeElapsed > delaytimer)
        {
           SceneManager.LoadScene(leveltoLoad);
        }
     }
}

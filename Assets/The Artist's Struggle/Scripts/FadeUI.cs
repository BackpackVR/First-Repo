using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FadeUI : MonoBehaviour
{
    public float timeBetweenFades;

    private float currentTime = 0;
    private CanvasGroup CanvasGroup;

    bool isActive = true;
    // Start is called before the first frame update
    void Start()
    {
     CanvasGroup = GetComponent<CanvasGroup>();   
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
       // Debug.Log(currentTime);
        if(currentTime >= timeBetweenFades && !isActive)
        {
            StartCoroutine(IFadeInRoutine());
        }
        else
        {
            StartCoroutine(IFadeOutRoutine());
        }
    }

    IEnumerator IFadeInRoutine()
    {
        yield return new WaitForSeconds(timeBetweenFades);
        CanvasGroup.DOFade(1, .8f);
        isActive = true;
        currentTime = 0;
    }

    IEnumerator IFadeOutRoutine()
    {
        yield return new WaitForSeconds(timeBetweenFades);
        CanvasGroup.DOFade(0, .8f);
        isActive=false;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestructionChecker : MonoBehaviour
{
    public int Totalpieces = 70;
    public UnityEvent OnAllPiecesDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Totalpieces <=0)
        {
            OnAllPiecesDestroyed.Invoke();
        }
    }
}

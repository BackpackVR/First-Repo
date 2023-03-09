using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
    public InputActionReference inputReference;
    public GameObject uiInstructions;

    public bool changeScene = false;

    private void Start()
    {
        uiInstructions.SetActive(false);
    }

    public void EnableInstructions()
    {
        uiInstructions.SetActive(true);
    }
    private void InputPressed(InputAction.CallbackContext ctx)
    {
        uiInstructions.SetActive(false);
        // Debug.Log("button Pressed!");
        if (changeScene)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    private void OnEnable()
    {
        inputReference.action.started += InputPressed;
    }

    private void OnDisable()
    {
        inputReference.action.started -= InputPressed;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text titleText;
    public Text contentText;
    public Step startStep;
    public Button button;

    public int[] numbers;

    Step currentStap;

   void Start()
    {
        currentStap = startStep;
        contentText.text = startStep.content;

        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            currentStap = currentStap.nextSteps[0];
            contentText.text = currentStap.content;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            currentStap = currentStap.nextSteps[1];
            contentText.text = currentStap.content;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {

            currentStap = currentStap.nextSteps[2];
            contentText.text = currentStap.content;
        }
    }

    public void Button ()
    {
        currentStap = currentStap.nextSteps[0];
        contentText.text = currentStap.content;
        button.gameObject.SetActive(false);
    }
}



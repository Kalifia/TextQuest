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
    public Image backgroundImage;


    Step currentStep;

    void Start()
    {
        currentStep = startStep;
        contentText.text = startStep.content;
        backgroundImage.sprite = startStep.nextImages;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)|| Input.GetKeyDown(KeyCode.Escape))
        {
            currentStep = currentStep.nextSteps[0];
            contentText.text = currentStep.content;
            backgroundImage.sprite = currentStep.nextImages;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Escape))
        {
            currentStep = currentStep.nextSteps[1];
            contentText.text = currentStep.content;
            backgroundImage.sprite = currentStep.nextImages;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Escape))
        {

            currentStep = currentStep.nextSteps[2];
            contentText.text = currentStep.content;
            backgroundImage.sprite = currentStep.nextImages;
        }
    }

    public void Button()
    {
        currentStep = currentStep.nextSteps[0];
        contentText.text = currentStep.content;
       backgroundImage.sprite = currentStep.nextImages;
        button.gameObject.SetActive(false);
    }
}



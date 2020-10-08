using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestSO: MonoBehaviour
{
    public Text titleText;
    public Text contentText;
    public StepSO startStep;
    public Button button;
    public Image backgroundImage;


    StepSO currentStep;

    void Start()
    {
        currentStep = startStep;
        contentText.text = startStep.content;
        backgroundImage.sprite = startStep.nextImages;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Escape))
        {
            NumberCheck(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Escape))
        {
            NumberCheck(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Escape))
        {
            NumberCheck(2);
        }
    }

    public void Button()
    {
        NumberCheck(0);
        button.gameObject.SetActive(false);
    }

    void UpdateStep()
    {
        contentText.text = currentStep.content;
        backgroundImage.sprite = currentStep.nextImages;
    }

    void NumberCheck(int number)
    {
        currentStep = currentStep.nextSteps[number];
        UpdateStep();
    }
}

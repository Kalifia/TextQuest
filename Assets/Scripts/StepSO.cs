using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Quest/Step", fileName = "New Step")]

public class StepSO : ScriptableObject
{
    [TextArea(15, 50)]
    public string content;


    public Sprite nextImages;
    public StepSO[] nextSteps;
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardStepper : MonoBehaviour
{
    [SerializeField]
    List<GameObject> steps;

    int previousStep;
    [SerializeField] GlobalInt currentStepGlobal;
    public int CurrentStep { get => currentStepGlobal.Value; set => currentStepGlobal.Value = value; }


    public void AdvanceStep(int direction)
    {
        previousStep = currentStepGlobal.Value;
        currentStepGlobal.Value += direction;
        ShowCurrentStep();
    }
    public void GoToStep(int specificStep)
    {
        previousStep = currentStepGlobal.Value;
        currentStepGlobal.Value = specificStep;
        ShowCurrentStep();
    }

    void ShowCurrentStep()
    {
        steps[previousStep].SetActive(false);
        steps[currentStepGlobal.Value].SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < steps.Count; i++)
        {
            steps[i].SetActive(false);
        }

        steps[currentStepGlobal.Value].SetActive(true);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

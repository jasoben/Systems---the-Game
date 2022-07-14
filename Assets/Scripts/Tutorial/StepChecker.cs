using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class StepChecker : MonoBehaviour, IWizardStep
{
    [SerializeField] UnityEvent stepComplete;

    public void StepCompleted()
    {
        stepComplete.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformChecker : StepChecker
{
    [SerializeField] GameObject objectToCheck;

    [SerializeField] Vector3 vectorDifference;

    [SerializeField] TransformToCheck transformToCheck;

    Vector3 newTransform;

    bool newValueSet;

    // Start is called before the first frame update
    void Start()
    {
        switch (transformToCheck)
        {
            case TransformToCheck.Position:
                newTransform = objectToCheck.transform.position + vectorDifference;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (newValueSet)
            return;

        switch (transformToCheck)
        {
            case TransformToCheck.Position:
                if (newTransform == objectToCheck.transform.position)
                    newValueSet = true;
                break;
        }

        if (newValueSet)
            StepCompleted();
    }
}
public enum TransformToCheck
{
    Position,
    Rotation,
    Scale
}

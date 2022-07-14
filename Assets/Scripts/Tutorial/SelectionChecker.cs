using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SelectionChecker : StepChecker
{
    [SerializeField] GameObject objectToSelect;
    public GameObject SelectedObject { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameObject)Selection.activeObject != SelectedObject)
        {
            SelectedObject = (GameObject)Selection.activeObject;
            if (SelectedObject == objectToSelect)
                StepCompleted();
        }
    }

}

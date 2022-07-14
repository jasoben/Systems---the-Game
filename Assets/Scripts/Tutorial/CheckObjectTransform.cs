using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObjectTransform : MonoBehaviour
{
    [SerializeField]
    GameObject objectToCheck;

    [SerializeField]
    Vector3 newVector;

    Vector3 startVector;

    [SerializeField]
    DirectionToCheck directionToCheck;

    [SerializeField]
    Axis axis;

    // Start is called before the first frame update
    void Start()
    {
        startVector = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum DirectionToCheck
{
    above,
    below,
    exact
}

public enum Axis
{
    xAxis,
    yAxis,
    zAxis
}

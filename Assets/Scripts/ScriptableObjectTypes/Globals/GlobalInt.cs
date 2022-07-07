using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Global/Int")]
public class GlobalInt : ScriptableObject
{
    [SerializeField]
    int value;

    public int Value { get => value; set => this.value = value; }
}

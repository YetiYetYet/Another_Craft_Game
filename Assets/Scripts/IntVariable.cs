using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Sirenix.OdinInspector;
using UnityEditor.Timeline.Actions;
using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "Variables/IntVariables")]
public class IntVariable : BaseVariable<int, IntEvent>
{
    
}

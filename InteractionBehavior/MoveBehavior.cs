using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveBehavior : OnInteractBehavior
{
    public Vector2 offsetVector;

    private void Update(){
        if(!Selected) return;
    }
}

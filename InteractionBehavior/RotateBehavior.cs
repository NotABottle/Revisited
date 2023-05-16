using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : OnInteractBehavior
{
    private void Update(){
        if(!Selected) return;
    }
}

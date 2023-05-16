using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private OnInteractBehavior onInteractBevhaior;

    private void Awake(){
        onInteractBevhaior = GetComponent<OnInteractBehavior>();
    }

    private void OnMouseDown(){
        onInteractBevhaior.Select();
    }

    private void OnMouseUp(){
        onInteractBevhaior.DeSelect();
    }
}

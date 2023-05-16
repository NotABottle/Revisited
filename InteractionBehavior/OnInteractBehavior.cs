using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class OnInteractBehavior : MonoBehaviour
{
    public bool Selected = false;

    public virtual void Select(){
        Selected = true;
    }

    public virtual void DeSelect(){
        Selected = false;
    }
}

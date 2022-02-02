using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAnimationController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ChangeAnimation(string AnimName, bool isWorked)
    {
        anim.SetBool(AnimName, isWorked);
    }
}

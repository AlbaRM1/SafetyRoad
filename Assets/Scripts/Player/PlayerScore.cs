using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int Score = 0;
    public List<string> Errors = new List<string>();    // Road, CrosswalkErr
    public List<string> Warning = new List<string>();
}

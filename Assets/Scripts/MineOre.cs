using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineOre : MonoBehaviour {

    [SerializeField]
    private int increment;
    public static event Action<int> Mine = delegate { };

    private void OnMouseUpAsButton() //checks if 
    {
        Mine(increment);
    }
}

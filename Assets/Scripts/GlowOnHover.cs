using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnHover : MonoBehaviour {

    [SerializeField]
    private GameObject glow;

    // Use this for initialization
    void Start()
    {
        glow.SetActive(false);
    }

    private void OnMouseOver()
    {
        glow.SetActive(true);
    }

    private void OnMouseExit()
    {
        glow.SetActive(false);
    }
}

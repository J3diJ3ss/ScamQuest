using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour {

    [SerializeField]
    private int goal;
    Text ore;

    private void Awake()
    {
        ore = GetComponent<Text>();
        ore.text = "0/" + goal;
    }

    // Use this for initialization
    void Start () {
        GameManager.UpdateScore += TextUpdate;
	}
	
	private void TextUpdate(int score)
    {
        string output = "";
        output = score + "/" + goal;
        ore.text = output;
    }
}

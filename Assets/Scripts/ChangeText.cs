using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

    [SerializeField]
    private List<string> text;
    private Text gameText;

    // Use this for initialization
    void Start()
    {
        gameText = gameObject.GetComponent<Text>();
        SceneManager.UpdatePerspective += newText;
    }

    void newText(int index)
    {
        gameText.text = text[index];
    }
}

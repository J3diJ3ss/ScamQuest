using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePicture : MonoBehaviour {

    [SerializeField]
    private List<Sprite> picture;
    SpriteRenderer background;

	// Use this for initialization
	void Start () {
        background = gameObject.GetComponent<SpriteRenderer>();
        SceneManager.UpdatePerspective += newPicture;
    }
	
	void newPicture(int index)
    {
        background.sprite = picture[index];
    }
}

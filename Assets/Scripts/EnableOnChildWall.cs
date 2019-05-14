using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnChildWall : MonoBehaviour {
    
    enum Perspective { Normal, Child, Parent}
    [SerializeField]
    private Perspective perspective;

	void Start () {
        SceneManager.UpdatePerspective += enableHandler;
    }

    void enableHandler(int perspective)
    {
        if (perspective == (int)this.perspective)
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        else
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}

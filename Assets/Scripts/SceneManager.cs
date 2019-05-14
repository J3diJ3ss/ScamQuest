using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
    

    [SerializeField]
    private List<GameObject> scenes;

    public static event Action<int> UpdatePerspective = delegate { };

    private int perspective;
    private int prevPerspective;
    private int index;

	// Use this for initialization
	void Start () {

        perspective = 0;
        prevPerspective = 0;

        for (int i = 1; i < scenes.Capacity; i++)
            scenes[i].SetActive(false);
        scenes[0].SetActive(true);
        index = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            index++;
            index %= scenes.Capacity;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            index--;
            index = (index + scenes.Capacity) % scenes.Capacity; // loops around 0 - 1 = n and n + 1 = 0 where n = number of scenes
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            perspective++;
            perspective = (perspective + 3) % 3;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            perspective--;
            perspective = (perspective + 3) % 3;
        }

        if (!scenes[index].active)
        {
            for (int i = 0; i < scenes.Capacity; i++)
                scenes[i].SetActive(false);
            scenes[index].SetActive(true);
        }

        if (prevPerspective != perspective)
        {
            UpdatePerspective(perspective);
            prevPerspective = perspective;
        }

	}
}

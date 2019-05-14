using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private bool specialPickaxe;
    private int gold;
    public static event Action<int> UpdateScore = delegate { };


	// Use this for initialization
	void Start ()
    {
        gold = 0;
        specialPickaxe = false;
        MineOre.Mine += MineGold;
	}

    void MineGold(int n)
    {
        gold += n;
        UpdateScore(gold);
    }
}

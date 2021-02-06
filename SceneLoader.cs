using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour 
{
    public void changemenuscene(string levelNumber)
	{
        Application.LoadLevel(levelNumber);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScenes : MonoBehaviour
{
    public static DataScenes instance;
    private int indexDancing;


    void Awake () {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            if (instance != this) {
                Destroy(gameObject);
            }
        }
    }
    public void SetIndex (int i){indexDancing = i;}
    public int GetIndex (){ return indexDancing;}
}

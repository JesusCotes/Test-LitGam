using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingGame : MonoBehaviour {

    public GameObject UIcharacter;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = UIcharacter.GetComponent<Animator>();
        anim.SetInteger("index", DataScenes.instance.GetIndex());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

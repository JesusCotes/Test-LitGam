using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DancingSelection : MonoBehaviour {

    int indexDancing;
    public GameObject character;
    Animator anim;

    void Start() {
      anim =  character.GetComponent<Animator>();
    }

    void Update() {}

    public void HipHop() {
      indexDancing = 0;
      Dancing();
      }
    public void Macarena() {
      indexDancing = 1;
      Dancing();
    }
    public void House() {
      indexDancing = 2;
      Dancing();
      }

    void Dancing () {
      anim.SetInteger("index", indexDancing);
      DataScenes.instance.SetIndex(indexDancing);
    }

    public void PlayGame (){
      SceneManager.LoadScene("Overworld");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class Player : MonoBehaviour {

  public int hp = 10;

  private static Player instance;

  public Text hpText;

  private Player () {}

  private void Start() {

  }

  public static Player Instance {
    get {
      if (instance == null)
        instance = GameObject.FindObjectOfType (typeof(Player)) as Player;
      return instance;
    }
  }

  private void OnTriggerEnter(Collider other){
    Destroy(other.gameObject);
    hp--;
  }

  private void FixedUpdate () {
    if(hp>0)
      hpText.text = hp.ToString();
    else
      hpText.text = "Game Over!";
  }

}

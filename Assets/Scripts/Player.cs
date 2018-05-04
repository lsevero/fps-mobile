using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Player : MonoBehaviour {

  private static Player instance;

  private Player () {}

  public static Player Instance {
    get {
       Debug.Log("get player");
      if (instance == null)
        instance = GameObject.FindObjectOfType (typeof(Player)) as Player;
      Debug.Log("instance: "+instance);
      return instance;
    }
  }

}

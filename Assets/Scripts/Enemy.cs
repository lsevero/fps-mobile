using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

  public float speed = 1f;

  private void Start() {}

  private void FixedUpdate () {
    transform.Translate((Player.Instance.transform.position - transform.position)
        * speed * Time.deltaTime);
  }

}

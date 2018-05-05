using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

  public float startTime = 2f;
  public float intervalTime = 2f;

  public GameObject enemy;

  private void Start()
  {
    InvokeRepeating("Spawn", startTime, intervalTime);
  }

  private void Spawn()
  {
    Vector3 position = new Vector3(Random.Range(-100f, 100.0f), Random.Range(-5f,20f), Random.Range(-100.0f, 100.0f));
    Instantiate(enemy, position, Quaternion.identity);
  }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

  private readonly float startTime = 2f;
  private readonly float intervalTime = 2f;

  public GameObject player;
  public GameObject enemy;

  private void Start()
  {
    Instantiate(player, new Vector3(0,0,0), Quaternion.identity);
    InvokeRepeating("Spawn", startTime, intervalTime);
  }

  private void Spawn()
  {
    Vector3 position = new Vector3(Random.Range(-30f, 30.0f), Random.Range(-15f,15f), Random.Range(-30.0f, 30.0f));
    Instantiate(enemy, position, Quaternion.identity);
  }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeBehaviour : MonoBehaviour {

  private bool gyroEnabled = false;
  private Gyroscope gyro;

  private GameObject cameraContainer;
  private Quaternion rot;

  private bool EnableGyro () {
    if(SystemInfo.supportsGyroscope)
    {
      gyro = Input.gyro;
      gyro.enabled = true;

      cameraContainer.transform.rotation = Quaternion.Euler(90f,90f,0f);
      rot = new Quaternion(0,0,1,0);

      return true;
    }
    return false;
  }

  // Use this for initialization
  private void Start () {
    cameraContainer = new GameObject("CameraContainer");
    cameraContainer.transform.position = transform.position;
    transform.SetParent(cameraContainer.transform);

    gyroEnabled = EnableGyro();
  }

  // Update is called once per frame
  private void Update () {
    if(gyroEnabled){
      transform.localRotation = gyro.attitude * rot;
    }
  }
}

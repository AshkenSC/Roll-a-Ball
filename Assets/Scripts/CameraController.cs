using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}

    // LateUpdate 在所有Update（）动作完成之后才执行，
    //因此将镜头移动放在此，确保镜头移动时，物体本帧确实已经发生了移动。
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}

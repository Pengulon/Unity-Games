using UnityEngine;
using System.Collections;

public class Arrow_Movement : MonoBehaviour {
	Transform nav;
	private float speed = 2f;
	// Use this for initialization
	void Awake()
	{
		nav = GetComponent<Transform> ();
	}

	void Update()
	{
		float step = speed * Time.deltaTime;
		nav.position = Vector3.MoveTowards (nav.position, new Vector3 (nav.position.x, 4f, nav.position.z), step);
		if (nav.position.y == 4f && gameObject.tag.Equals("arrow")) {
			DestroyObject (gameObject);
		}
	}
}

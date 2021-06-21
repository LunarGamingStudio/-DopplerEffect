using UnityEngine;

public class LookAt : MonoBehaviour
{
	private Vector2 rotation;
	public float speed = 3;

    private void Start()
    {
		rotation = -transform.rotation.eulerAngles;
	}

    void Update()
	{
		if (Input.GetMouseButton(0))
		{
			rotation.y += Input.GetAxis("Mouse X");
			transform.eulerAngles = rotation * speed;
		}
	}
}

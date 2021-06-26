using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollow : MonoBehaviour
{
	AhsapController _ahsapController;
	BallController _ballController;

	public List<GameObject> movedBalls;
	private void Awake()
	{
		_ahsapController = FindObjectOfType<AhsapController>();
		_ballController = FindObjectOfType<BallController>();
	}
	private void Start()
	{
		movedBalls = new List<GameObject>();
	}
	//private void OnCollisionStay(Collision collision)
	//{
	//	//Debug.Log("Çarpışma");
	//	BallController ballController = collision.gameObject.GetComponent<BallController>();


	//	if (ballController != null && _ahsapController.isRight)
	//	{
	//		Debug.Log("ccccc");
	//		ballController.transform.position = new Vector3(gameObject.transform.position.x, ballController.transform.position.y, ballController.transform.position.z);
	//	}
	//	if(ballController != null && _ahsapController.isRight == false)
	//	{
	//		ballController.transform.position = new Vector3(gameObject.transform.position.x, ballController.transform.position.y, ballController.transform.position.z);
	//	}

	//}

	private void Update()
	{
		Follow();
	}
	public void Follow()
	{
		if (_ahsapController.isRight)
		{
			foreach (var item in movedBalls)
			{
				item.transform.position = new Vector3(gameObject.transform.position.x, item.transform.position.y, item.transform.position.z);
			}
		}
		else if(_ahsapController.isRight == false)
		{
			foreach (var item in movedBalls)
			{
				item.transform.position = new Vector3(gameObject.transform.position.x, item.transform.position.y, item.transform.position.z);
			}
		}
	}

	public void AddMovedBall(GameObject ball)
	{
		movedBalls.Add(ball);
	}
	public void RemoveMovedBall(GameObject ball)
	{
		movedBalls.Remove(ball);
	}


}

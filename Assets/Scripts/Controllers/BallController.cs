using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	AhsapController _ahsapController;
	BallFollow _ballFollow;


	public bool isPass;
	public bool isPassLeft;
	public bool isMoved;
	private void Awake()
	{
		_ahsapController = FindObjectOfType<AhsapController>();
		_ballFollow = FindObjectOfType<BallFollow>();
		screenHeight = Display.main.systemHeight;
		screenWidth = Display.main.systemWidth;

	}
	private void Start()
	{
		isMoved = false;
	}
	private void Update()
	{
		//if (Input.GetMouseButtonDown(0))
		//{
		//	isPass = true;
		//}
		PlayerMovement();
	}
	private void OnTriggerStay(Collider other)
	{
		LeftMover(other);
		RightMover(other);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ahsap"))
		{
			isMoved = true;
			_ballFollow.AddMovedBall(gameObject);
		}
	}
	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ahsap"))
		{
			isMoved = false;
			_ballFollow.RemoveMovedBall(gameObject);
		}
	}

	void RightMover(Collider other)
	{
		if (isPass && _ahsapController.isRight == true)
		{
			if (other.CompareTag("1r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("2r").transform.position;
				isPass = false;
			}
			else if (other.CompareTag("2r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("3r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("3r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("4r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("4r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("5r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("5r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("6r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("6r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("7r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("7r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("8r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("8r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("9r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("9r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("10r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("10r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("11r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("11r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("12r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("12r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("13r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("13r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("14r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("14r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("15r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("15r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("16r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("16r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("17r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("17r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("18r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("18r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("19r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("19r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("20r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("20r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("21r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("21r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("22r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("22r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("23r").transform.position;
				isPass = false;

			}
			else if (other.CompareTag("23r"))
			{
				transform.position = GameObject.FindGameObjectWithTag("1r").transform.position;
				isPass = false;

			}
		}
	}

	void LeftMover(Collider other)
	{
		if (isPassLeft && _ahsapController.isRight == false)
		{
			if (other.CompareTag("1"))
			{
				Debug.Log("aaa");
				transform.position = GameObject.FindGameObjectWithTag("2").transform.position;
				isPassLeft = false;
			}
			else if (other.CompareTag("2"))
			{
				Debug.Log("bbb");
				transform.position = GameObject.FindGameObjectWithTag("3").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("3"))
			{
				transform.position = GameObject.FindGameObjectWithTag("4").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("4"))
			{
				transform.position = GameObject.FindGameObjectWithTag("5").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("5"))
			{
				transform.position = GameObject.FindGameObjectWithTag("6").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("6"))
			{
				transform.position = GameObject.FindGameObjectWithTag("7").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("7"))
			{
				transform.position = GameObject.FindGameObjectWithTag("8").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("8"))
			{
				transform.position = GameObject.FindGameObjectWithTag("9").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("9"))
			{
				transform.position = GameObject.FindGameObjectWithTag("10").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("10"))
			{
				transform.position = GameObject.FindGameObjectWithTag("11").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("11"))
			{
				transform.position = GameObject.FindGameObjectWithTag("12").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("12"))
			{
				transform.position = GameObject.FindGameObjectWithTag("13").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("13"))
			{
				transform.position = GameObject.FindGameObjectWithTag("14").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("14"))
			{
				transform.position = GameObject.FindGameObjectWithTag("15").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("15"))
			{
				transform.position = GameObject.FindGameObjectWithTag("16").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("16"))
			{
				transform.position = GameObject.FindGameObjectWithTag("17").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("17"))
			{
				transform.position = GameObject.FindGameObjectWithTag("18").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("18"))
			{
				transform.position = GameObject.FindGameObjectWithTag("19").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("19"))
			{
				transform.position = GameObject.FindGameObjectWithTag("20").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("20"))
			{
				transform.position = GameObject.FindGameObjectWithTag("21").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("21"))
			{
				transform.position = GameObject.FindGameObjectWithTag("22").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("22"))
			{
				transform.position = GameObject.FindGameObjectWithTag("23").transform.position;
				isPassLeft = false;

			}
			else if (other.CompareTag("23"))
			{
				transform.position = GameObject.FindGameObjectWithTag("1").transform.position;
				isPassLeft = false;

			}
		}
	}



	public float speed = 20f;
	public float thrust = 3f;

	private Vector2 deltaPos;
	private Vector2 lastMousePos;

	[HideInInspector] public int screenHeight;
	[HideInInspector] public int screenWidth;


	public void PlayerMovement()
	{
		HandleMouse();

		if (deltaPos != Vector2.zero)
		{
			float move = Mathf.Abs((100f / (float)(screenHeight) * deltaPos.y * thrust));
			if (move > 2)
			{

				if (deltaPos.y > 0)
				{
					if (_ahsapController.isRight)
						isPass = true;
					if (_ahsapController.isRight == false)
						isPassLeft = true;
				}
				else
				{

				}
			}


			//float posY = move * Time.deltaTime * (deltaPos.y < 0 ? -1 : 1);
			//Debug.Log("Pozisyon yönü : " + posY);
			//pos.x += posX;
			//pos.x = Mathf.Clamp(pos.x, -4.246f, 4.246f);
		}

		//pos.z += Time.deltaTime * speed;
		//transform.position = pos;
	}

	private void HandleMouse()
	{
		deltaPos = Vector2.zero;
		if (Input.GetMouseButton(0))
		{
			Vector2 currentMousePos = Input.mousePosition;
			if (lastMousePos == Vector2.zero)
			{
				lastMousePos = currentMousePos;
			}
			deltaPos = currentMousePos - lastMousePos;
			lastMousePos = currentMousePos;
		}
		else
		{
			lastMousePos = Vector2.zero;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aimona
{
	public class Player : MonoBehaviour {
		// Static
		public const int maxleath = 100;

		// Public
		[HideInInspector]
		public bool Landed;
		[HideInInspector]
		public bool Running;
		[HideInInspector]
		public bool Firing;
		[HideInInspector]
		public Vector2 vector;

		[HideInInspector]
		public Rigidbody2D playerBody;
		[HideInInspector]


		// Private
		private PlayerMove playerMove;
		private PlayerFire playerFire;
		private Animator animator;
		private bool isDead = false;
		private int health = 100;
		void Start () {
			_Init();
		}
		
		// Update is called once per frame
		void Update () {

		}

		private void _Init()
		{
			playerMove =  GetComponent<PlayerMove>();
			playerFire = GetComponent<PlayerFire>();
			animator = GetComponent<Animator>();
			Landed = true;
			Running = false;
			Firing = false;
		}

		private void _Reverse()
		{

		}
	}
}
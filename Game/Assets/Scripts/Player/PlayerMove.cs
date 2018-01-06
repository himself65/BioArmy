using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aimona {
	public class PlayerMove : MonoBehaviour {
		[HideInInspector]
		private bool canRun = true;
		[Tooltip("Player's Walking Speed")]
		private float walkSpeed = 7.0f;
		[Tooltip("Player's Running Speed")]
		private float runSpeed = 10.0f;

		[HideInInspector]
		private Player player;
		void Start () {
			player = GetComponent<Player>();
		}
		
		void FixedUpdate()
		{
			bool running = Input.GetButton("MoveV");
			float speed = GetSpeed();
		}

	#region Speed
		private float GetSpeed()
		{
			bool running = Input.GetButton("MoveV") || Input.GetButton("MoveH");
			player.vector.x = Input.GetAxis("MoveH");
			player.vector.y = Input.GetAxis("MoveV");
			
			float speed = runSpeed;

			if(canRun)
			{
				speed = running ? runSpeed : walkSpeed;
			}
			else
			{
				speed = walkSpeed;
			}

			return speed;
		}
	#endregion

	}
}
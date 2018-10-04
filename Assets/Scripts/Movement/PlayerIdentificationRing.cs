﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerIdentificationRing : MonoBehaviour 
{
	#region Member Variables
	
		[Header("Ring Details")]
		[SerializeField]
		private Color _ColorWhileMoving = Color.gray;

		private NavMeshAgent _HeroNavMesh;
		private Color _ColorWhenNotMoving;
		private Renderer _Renderer;

	#endregion

	#region Life Cycle

		private void Start() 
		{
			_HeroNavMesh = GetComponentInParent<NavMeshAgent>();
			_Renderer = GetComponent<Renderer>();
		}

		private void LateUpdate() 
		{
			// FIXME: To optimize later
			_Renderer.material.color = _ColorWhileMoving;

			if (_HeroNavMesh.velocity.sqrMagnitude <= 0.1f)
			{
				_Renderer.material.color = _ColorWhenNotMoving;
			}
		}

	#endregion

	#region Member Functions

		public void Initialize(Color colorWhenNotMoving)
		{
			_ColorWhenNotMoving = colorWhenNotMoving;
		}

	#endregion
}

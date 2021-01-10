using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DTAccao : MonoBehaviour
{
	// Start is called before the first frame update

	public class DTAction : DTNode
	{
		private Action action;

		public DTDTAccao()
		{
			this.action = action;
		}

		public override void Run()
		{
			action();
		}
	}
}

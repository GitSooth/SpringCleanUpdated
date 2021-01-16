using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DTAccao : DTNode
{
	// Start is called before the first frame update

	
		private Action action;

		public DTAccao(Action action)
		{
			this.action = action;
		}

		public override void Run()
		{
			action();
		}
	
}

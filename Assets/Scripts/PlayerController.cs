using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Combatant
{	
	public override float dealDmg()
	{
		Debug.Log("Player");
		//Play the animation, describe what happened in text
		return attackPower;
	}
}

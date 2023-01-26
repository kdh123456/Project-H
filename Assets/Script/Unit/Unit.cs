using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class UnitStat
{
	public int atk;
	public int defense;
	public int speed;

	public UnitStat(UnitStat c)
	{
		atk = c.atk;
		defense = c.defense;
		speed = c.speed;
	}
}

[CreateAssetMenu(fileName = "UnitSO", menuName = "SO/Unit")]
public class Unit : ScriptableObject
{
	public string UnitName; //대충 유닛 이름
	public string UnitComment; //대충 유닛 설명

	[SerializeField]
	private UnitStat _originstat;

	public UnitStat changeStat;

	private void OnEnable()
	{
		changeStat = new UnitStat(_originstat);
	}
}

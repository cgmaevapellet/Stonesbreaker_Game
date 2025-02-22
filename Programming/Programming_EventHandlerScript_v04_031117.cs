﻿using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour 
{
	private CharacterMovement characterMovement;
	private BossController bossController;
	private CharacterHealth characterHealth;

	// Use this for initialization
	void Awake () 
	{
		characterMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
		bossController = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossController>();
		characterHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterHealth>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void EnableBossBattle()
	{
		characterMovement.enabled = true;
		bossController.inBattle = true;
	}

	void UpdateBossAttack()
	{
		bossController.UpdateAttackCount();
	}


	void CallFireProjectile()
	{
		characterMovement.FireProjectile();
	}

	void CallFallApart()
	{
		characterHealth.FallApart();
	}

	void CallEnableEye()
	{
		bossController.EnableEye();
	}

	void CallDisableEye()
	{
		bossController.DisableEye();
	}

	void CallPlayIntroAudio()
	{
		bossController.PlayIntroAudio();
	}

	void CallSmashAudio()
	{
		bossController.PlaySmashAudio();
	}

	void CallDeathAudio()
	{
		bossController.PlayDeathAudio();
	}

	void CallAttackTimer()
	{
		bossController.ActivateAttackTimer();
	}

	void SetAttacking()
	{
		bossController.attacking = true;
	}

	void CallInBattle()
	{
		bossController.inBattle = true;
	}
	
}

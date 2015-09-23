﻿using UnityEngine;
using System.Collections;

public class CharacterInfo {

	public Attributes attributes;
	public Skill[] skills;
	public Effects effects;

	#region Constructor
	public CharacterInfo() {
		
	}
	#endregion

	#region Attributes
	public class Attributes {

		public float baseDamage;
		public float blockChance; //Dodge / Parry / Block chance
		public float criticalChance;
		public float agility;
		public float strength;
		public float intelligent;
		public float armor;

		public float hp;
		public float mp;
		public float damage;
		public float spellDamage;
		public float damaged;

		public Attributes() {
		}

		public Attributes(float BaseDamage, float BlockChance, float CriticalChance, float Agility, float Strength, float Intelligent, float Armor) {
			baseDamage = BaseDamage;
			blockChance = BlockChance;
			criticalChance = CriticalChance;
			agility = Agility;
			strength = Strength;
			intelligent = Intelligent;
			armor = Armor;

			__calc();
		}

		public Attributes(float[] attributes) {
			baseDamage = attributes[0];
			blockChance = attributes[1];
			criticalChance = attributes[2];
			agility = attributes[3];
			strength = attributes[4];
			intelligent = attributes[5];

			__calc();
		}

		// Formular

		private void __calc() {
			hp = getHP();
			mp = getMP();
			damage = getDamage();
			spellDamage = getSpellDamage();
			damaged = getDamaged();
		}

		/**
		 *  Get Damage
		 **/
		public float getDamage() {
			// TODO
			float minDamage = 0;
			float maxDamage = 0;
			return 0;
		}

		/**
		 *  Get Critical Damage
		 **/
		public float getCriticalDamage() {
			// TODO
			return 0;
		}

		/**
		 *  Get Block Chance
		 **/
		public float getBlockChance() {
			// TODO
			return 0;
		}

		/**
		 *  Get Health
		 **/
		public float getHP() {
			// TODO
			return 0;
		}

		/**
		 *  Get Mana
		 **/
		public float getMP() {
			// TODO
			return 0;
		}

		/**
		 *  Get Spell Damage
		 **/
		public float getSpellDamage() {
			// TODO
			return 0;
		}

		/**
		 *  Get Damaged
		 **/
		public float getDamaged() {
			// TODO
			return 0;
		}

	}
	#endregion

	#region Effects
	public class Effects {

		// TODO
		public float reflectDamage;
		public int stunned;
		public int activeSkill;
		public float bleeded;
		public Object increaseAttributes;

		public Effects() {
		}
	}
	#endregion

	#region Skill
	public class Skill {
		
		// TODO
		public string name;
		public int level = 1;
		
		public Skill() {
		}
		
		public Skill(string Name) {
			name = Name;
		}
		
		public Skill(string Name, int Level) {
			name = Name;
			level = Level;
		}
	}
	#endregion
}

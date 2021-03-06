﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using O2F;

public class Object2FormTest : MonoBehaviour
{	
	void Start ()
	{
		CreatePlayerEditForm();
		//CreateItemEditForm();
	}
	
	private void CreatePlayerEditForm()
	{
		Player player = new Player();
		player.id = Guid.NewGuid().ToString().Substring(0, 10).ToUpper();
		player.name = "Rodrigo";
		player.life = 100;
		player.precision = 1.0f;
		player.strength = 10;
		player.controlledByBot = true;
		player.isAlive = true;
		player.characterClass = CharacterClass.Rogue;

		player.items.Add(new Item("Shield", new Price(10, 50), 0, 10, ItemCategory.Shield));
		player.items.Add(new Item("Sword", new Price(100, 500), 10, 10, ItemCategory.Weapon));
		player.items.Add(new Item("Helmut", new Price(1, 5), 0, 5, ItemCategory.Armor));

		//player.items.Add(CharacterClass.Wizard);
		//player.items.Add(CharacterClass.Warrior);

		//player.items.Add("Shield");
		//player.items.Add("Sword");
		//player.items.Add("Helmut");
		//player.items.Add(10);
		//player.items.Add(100);
		//player.items.Add(1000);

		//CreateItemEditForm();

		Object2Form.Instance.CreateEditForm(player);

		//Object2Form.Instance.CreateNewForm<Player>();
	}

	private void CreateItemEditForm()
	{
		Price price = new Price(100, 100);

		Item item = new Item();
		item.name = "Dragon Slayer Sword";
		item.price = price;
		item.resistance = 10;
		item.damage = 5;
		item.category = ItemCategory.Weapon;

		Object2Form.Instance.CreateEditForm(item);
	}
}

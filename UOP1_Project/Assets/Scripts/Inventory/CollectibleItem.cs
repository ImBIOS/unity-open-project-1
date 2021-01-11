﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{

	[SerializeField] private Item _currentItem = default;

	[SerializeField] private SpriteRenderer[] _itemImages = default;
	private void Start()
	{
		SetItem();
	}

	public void PickedItem()
	{


	}

	public Item GetItem()
	{
		Debug.Log("current item " + _currentItem);
		return _currentItem;

	}

	//this function is only for testing 
	public void SetItem()
	{
		for (int i = 0; i < _itemImages.Length; i++)
		{
			_itemImages[i].sprite = _currentItem.PreviewImage;
		}

	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			if (other.gameObject.GetComponent<ItemPicker>())
			{

				other.gameObject.GetComponent<ItemPicker>().PickItem(_currentItem);

			}

		}
	}
}

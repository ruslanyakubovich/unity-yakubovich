﻿using System;
using UnityEngine;
namespace PixselCrew.Model
{
    [Serializable]
    public class PlayerData
    {
        [SerializeField] private InventoryData _inventory;

        public IntProperty Hp = new IntProperty();

        public InventoryData Inventory => _inventory;

        public PlayerData clone()
        {
            // делаем копию всех полей объекта 
            var j = JsonUtility.ToJson(this);
            return JsonUtility.FromJson<PlayerData>(j);
        }
    }
}

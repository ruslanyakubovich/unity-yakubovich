﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixselCrew.Model
{
    /*
     объект который хранит в себе описания 
     */
    [CreateAssetMenu(menuName = "Defs/DefsFacade", fileName = "DefsFacade")]
    public class DefsFacade : ScriptableObject
    {
        private const string cnstDefsFacade = "DefsFacade";

        [SerializeField] private InventoryItemsDef _items;

        public InventoryItemsDef Items => _items;

        private static DefsFacade _instance;
        public static DefsFacade I => _instance == null ? LeadDef() : _instance;



        private static DefsFacade LeadDef()
        {
            return Resources.Load<DefsFacade>(cnstDefsFacade);
        }
    }
}

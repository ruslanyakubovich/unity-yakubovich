﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixselCrew.Model
{
    /*
     объект который хранит в себе описания (не изменяемые данные)

    чтобы из любого места в приложении могли достучаться до списка 
    всех описаний предметов 
     */
    [CreateAssetMenu(menuName = "Defs/DefsFacade", fileName = "DefsFacade")]
    public class DefsFacade : ScriptableObject
    {
        private const string cnstDefsFacade = "DefsFacade";

        [SerializeField] private ItemsRepository _items;
        [SerializeField] private ThrowableRepository _throwableItems;
        [SerializeField] private PotionRepository _potions;
        [SerializeField] private PlayerDef _player;

        public ItemsRepository Items => _items;
        public ThrowableRepository Throwable => _throwableItems;
        public PotionRepository Potions => _potions;

        public PlayerDef Player => _player;

        private static DefsFacade _instance;
        public static DefsFacade I => _instance == null ? LeadDef() : _instance;



        private static DefsFacade LeadDef()
        {
            return Resources.Load<DefsFacade>(cnstDefsFacade);
        }
    }
}

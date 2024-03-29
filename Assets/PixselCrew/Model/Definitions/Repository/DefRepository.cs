﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixselCrew.Model
{
    public class DefRepository<TDefType> : ScriptableObject where TDefType : IHaveId
    {
        // общее поле коллекции 
        [SerializeField] protected TDefType[] _collection;

        public TDefType Get(string id)
        {
            if (string.IsNullOrEmpty(id))
                return default;

            foreach (var item in _collection)
                if (item.Id == id)
                    return item;

            return default;
        }
    }
}

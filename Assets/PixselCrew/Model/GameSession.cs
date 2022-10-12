﻿using UnityEngine;
namespace PixelCrew.Model
{
    public class GameSession : MonoBehaviour
    {
        [SerializeField] private PlayerData _data;
        public PlayerData Data => _data;
        private void Awake()
        {
            if (IsSessionExit())
            {
                DestroyImmediate(gameObject);
            }
            else {
                // помещаем объект в «хранилище» которое на удаляется между сценами 
                DontDestroyOnLoad(this);
            }
        }
        private bool IsSessionExit()
        {
            var sessions = FindObjectsOfType<GameSession>();
            foreach (var gameSession in sessions)
                if (gameSession != this)
                    return true;

            return false;
        }
    }
}

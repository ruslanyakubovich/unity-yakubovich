﻿using System;
using UnityEngine;

/// <summary>
/// Создание префаба в игре в заданной позиции 
/// </summary>
public class SpawnComponent : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private GameObject _prefab;

    [ContextMenu("Spawn")]
    public void Spawn()
    {
        var instante = Instantiate(_prefab, _target.position, Quaternion.identity);

        // присваеваем значения «мира» (а не относительные) 
        instante.transform.localScale = _target.lossyScale;
    }

    public void SetPrefab(GameObject prefab)
    {
        _prefab = prefab;

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using Interfaces;
using Map;
using Player;
using Status;
using UnityEngine;


public class PlayerCreator : MonoBehaviour
{
    private const string NamePlayer = "Player";

    public Action Ended;

    private UnityKeyboarInput _keyBoardInput = new UnityKeyboarInput();
    private Vector2 _position = new Vector2(1, 0);
    private PlayerController _playerController;
    private PlayerModel _playerModel;
    private PlayerConsoleStatus _playerConsoleStatus;
    private int _heath = 5;
    private int _pickaxe = 5;


    public void CreateNewPlayer(MapController mapController)
    {
        _playerModel = new PlayerModel(_heath, _pickaxe, _position);
        PlayerView playerView = new PlayerView(_playerModel);
        _playerController = new PlayerController(_keyBoardInput, mapController, _playerModel, playerView);
        _playerController.Create();
    }

    public Vector2 GetPosition()
    {
        return _playerModel.CurrentPosition;
    }

    public PlayerModel GetPlayer()
    {
        return _playerModel;
    }

    private void Update()
    {
        if (_playerController != null)
            _playerController.Manage();
    }

}


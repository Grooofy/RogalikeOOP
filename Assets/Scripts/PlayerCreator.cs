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
    private KeyBoardInput _keyBoardInput = new KeyBoardInput();
    private Vector2 _position = new Vector2(1, 0);
    private PlayerController _playerController;
    private PlayerModel _playerModel;
    private PlayerConsoleStatus _playerConsoleStatus;
    private int _heath = 5;
    private int _pickaxe = 5;
    public Action Ended;

    public void CreateNewPlayer()
    {
        _playerModel = new PlayerModel(_heath, _pickaxe, _position, 0);
        PlayerView playerView = new PlayerView(_playerModel);
       // _playerController = new PlayerController(_keyBoardInput, mapController, _playerModel, playerView);
        _playerController.Create();
    }

    public void Manage(bool IsGameOver, Vector2 ExitPosition)
    {
        while (IsGameOver == false)
        {
            _playerController.Manage();
            if (_playerModel.CurrentPosition == ExitPosition)
            {
                Ended?.Invoke();
            }
        }
    }
}


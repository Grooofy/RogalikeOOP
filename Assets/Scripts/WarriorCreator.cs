using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces;
using Map;
using Player;
using Enemy;


public class WarriorCreator : MonoBehaviour
{
    [SerializeField] private float _speed;
    private WarriorModel _warriorModel;
    private WarriorView _warriorView;
    private WarriorController _warriorController;
    private AiInput _aiInput = new AiInput();
    private int _positionX;
    private int _positionY;
    private float _timer = 300;
    private float _startTime = 300;


    public void CreateWarriors(MapController mapController, PlayerModel player, int count)
    {
        for (int i = 0; i < count; i++)
        {
            _positionX = Random.Range(1, mapController.Weight - 1);
            _positionY = Random.Range(1, mapController.Height - 1);
            CreateWarrior(mapController, player);

        }
    }

    public void Destroy(int count)
    {
        for (int i = 0; i < count; i++)
        {
            _warriorController.Destroy();
        }
    }

    private void CreateWarrior(MapController mapController, PlayerModel player)
    {
        _warriorModel = new WarriorModel(new Vector2(_positionX, _positionY), player);
        _warriorView = new WarriorView(_warriorModel);
        _warriorController = new WarriorController(_aiInput, mapController, _warriorModel, _warriorView);
    }

    private void Update()
    {
        if (_warriorController != null)
            if (_timer < 0)
            {
                _warriorController.Manage();
                _timer = _startTime;
            }
        _timer -= _speed;
    }
}

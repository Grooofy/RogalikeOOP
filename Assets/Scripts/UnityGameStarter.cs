using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Map;
using UnityEngine.SceneManagement;

public class UnityGameStarter : MonoBehaviour
{
    [SerializeField] private int _height;
    [SerializeField] private int _weight;
    [SerializeField] private PlayerCreator _playerCreator;
    [SerializeField] private WarriorCreator _warriorCreator;

    private MapModel _mapModel;
    private MapView _mapView;
    private MapController _controller;

    private Vector2 _finishPosition;



    private void OnEnable()
    {
       LoadGame();
    }

    private void Update()
    {
        if(_finishPosition == _playerCreator.GetPosition())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void LoadGame()
    {
        CreateMap();
        CreatePlayer();
        CreateWarriors();
        _finishPosition = _controller.GetExitPosition();
    }

    private void CreateMap()
    {
        _mapModel = new MapModel();
        _mapView = new MapView();
        _controller = new MapController(_mapModel, _mapView, _height, _weight);
        _controller.Create(transform);
    }

    private void CreatePlayer()
    {
        _playerCreator.CreateNewPlayer(_controller);
    }

    private void CreateWarriors()
    {
        _warriorCreator.CreateWarriors(_controller, _playerCreator.GetPlayer(), 1);
    }

}

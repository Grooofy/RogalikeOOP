using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Map;

public class UnityGameStarter : MonoBehaviour
{
    [SerializeField] private int _height;
    [SerializeField] private int _weight;

    private MapModel _mapModel;
    private MapView _mapView;
    private MapController _controller;



    void Start()
    {
        CreateMap();
    }

    private void CreateMap()
    {
        _mapModel = new MapModel();
        _mapView = new MapView();
        _controller = new MapController(_mapModel, _mapView, _height, _weight);
        _controller.Create(transform);
    }
}

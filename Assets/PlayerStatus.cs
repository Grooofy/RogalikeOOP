using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Player;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private TextMeshProUGUI _itemText;
    [SerializeField] private PlayerCreator _creator;
    private PlayerModel _model;


    private void Start()
    {
        _model = _creator.GetPlayer();
        _model.TakingDamage += ShowHealth;
        _model.PickaxeAmountChanged += ShowItems;

        ShowHealth(_model.Health);
        ShowItems(_model.Pickaxe.HitAmount);

    }

    private void OnDisable()
    {
        _model.TakingDamage -= ShowHealth;
        _model.PickaxeAmountChanged -= ShowItems;
    }

    public void ShowHealth(int count)
    {
        _healthText.text = $"Жизни {count}";
    }

    public void ShowItems(int count)
    {
        _itemText.text = $"Кирки {count}";
    }
}

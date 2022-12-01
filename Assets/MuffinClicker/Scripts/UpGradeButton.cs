using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpGradeButton : MonoBehaviour
{
    [SerializeField]
    private GameManager _gameManager;

    [SerializeField]
    private TextMeshProUGUI _levelText; //referece TMPro element

    [SerializeField]
    private float _costPowerScale = 1.5f;

    [SerializeField]
    private TextMeshProUGUI _costText;

    //[SerializeField]
    //private int [] _costPerLevel;

    private int _level;

    private int CurrentCost
    {
        get
        {
            return 5 + Mathf.RoundToInt(Mathf.Pow(_level, _costPowerScale));
            //int length = _costPerLevel.Length;

            //if (length == 0)
            //{
            //    return 0;
            //}

            //int index = Mathf.Clamp(_level, 0, length - 1);

            //return _costPerLevel[index];
        } 
    }

    public int Level 
    { 
        get => _level;
        private set
        {
            _level = value;
        }   
    }

    private void Start()
    {
        UpdateUI();
        Level = 0;
    }
    public void TotalMuffinsChanged(int totalMuffin)
    {
        bool canAfford = totalMuffin >= CurrentCost;
        _costText.color = canAfford ? Color.green : Color.red;

        //if (canAfford)
        //{
        //    //afford it
        //    _costText.color = Color.green;
        //}
        //else
        //{
        //    _costText.color = Color.red;
        //}
    }
    public void OnUpgradeClicked()
    {
        int currentCost = CurrentCost;
        bool purchasedUpgrade =_gameManager.TryPurchaseUpgrade(currentCost, Level);
        if (purchasedUpgrade)
        {
            Level++;
            UpdateUI();
        }
    }
    private void UpdateUI()
    {
        _levelText.text = _level.ToString();
        _costText.text = CurrentCost.ToString();
    }
}

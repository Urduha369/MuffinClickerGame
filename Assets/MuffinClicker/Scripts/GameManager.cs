using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Move Game State into GameManager, responsible for the counter and the changes to the counter
/// </summary>
public class GameManager : MonoBehaviour
{
    public UnityEvent<int> OnTotalMuffinsChanged;
  
    [Range(0f, 1f)]
    [SerializeField]
    private float _critChance = 0.01f;

    private int _muffinsPerClick = 1;
    private int _totalMuffins = 0;

    public float _muffinsPerSecond = 0f;
   

    private int TotalMuffins
    {
        get
        {
            return _totalMuffins;
        }
        set
        {
            _totalMuffins = value;
            OnTotalMuffinsChanged.Invoke(_totalMuffins);
        }
    }

    /// <summary>
    /// Adds muffins to he total muffins
    /// </summary>
    /// <returns>Returns the added muffins</returns>
    public int AddMuffins()
    {
         int addedMuffins = 0;
        if (Random.value <= _critChance)
        {
            // Crit
            addedMuffins = _muffinsPerClick * 10;
        }
        else
        {
            //Normal
            addedMuffins = _muffinsPerClick;
        }
        TotalMuffins += addedMuffins;

        Invoke("AddMuffins", 1 / _muffinsPerSecond);
        return addedMuffins;
    }
    public bool TryPurchaseUpgrade(int currentCost, int level)
    {
        if (TotalMuffins >= currentCost)
        {
            //Able to afford it Purchase
            TotalMuffins -= currentCost;
            level++;

            _muffinsPerClick = 1 + level * 2;

            return true;
        }

        return false;

    }
    private void Start()
    {
        TotalMuffins = 0;
        Invoke("AddMuffins", 1 / _muffinsPerSecond);
    }
    private void update()
    {
        
    }
}

public class SaveFileHandler : MonoBehaviour
{

    private void Awake()
    {
        Application.wantsToQuit += Application_wantsToQuit;
    }

    private bool Application_wantsToQuit()
    {
        //Create a save popup

        return false;
    }

    private void OnDestroy()
    {
        Application.wantsToQuit -= Application_wantsToQuit;

    }
}


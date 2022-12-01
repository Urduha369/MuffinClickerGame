using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MuffinClicker : MonoBehaviour
{
    /// <summary>
    /// 1. Tell Game Manager to Add Muffins           = MuffinClicker
    /// 2. Keep track of our total muffins            = GameManager
    /// 3. Handles critical chance logic              = GameManager
    /// 4. Creates the spin transform animations      = SpinPulseTransform
    /// 5. Creates the scale transform animations     = SpinPulseTransform
    /// 6. Generates and animates the Text Reward pop-ups     = MuffinClicker
    /// 7. Updates the total muffin counter & Display it      = Header
    /// </summary>

    [SerializeField]
    private GameManager _gameManager;
    
    [SerializeField]
    private TextMeshProUGUI _textRewardPrefab;

    [SerializeField]
    private Texture2D[] _desserts;

    [SerializeField]
    RawImage image;

    [SerializeField]
    private float _lowRangeX, _highRangeX, _lowRangeY, _highRangeY;


    ////create an index
    ////int index = 0;

    ////transform.Rotate(rotation);  //rotates the current transform - THIS Spins Muffin

    //RandomNumber rnd = new RandomNumber();
    //}

    //To create a constructor, exactly like a method but the name of the method is the same as the class
    //purpose is to hold a random number
    //public class RandomNumber
    //{
    //    public int _randomNumber;

    //    public RandomNumber()
    //    {
    //        _randomNumber = Random.Range(-10, 10);
    //    }

    //    public RandomNumber(int value)
    //    {
    //        _randomNumber = value;
    //    }
    //}
    public void onMuffinClicked()
    {
        // Add Muffins
        int addedMuffins = _gameManager.AddMuffins();

        //CreateTextRewardPrefab(addedMuffins);
    }

    //private void CreateTextRewardPrefab(int addedMuffins)
    //{
        //TextMeshProUGUI textRewardClone = Instantiate(_textRewardPrefab, transform);
        //Vector2 randomVector = MyToolbox.GetRandomVector2(_lowRangeX, _highRangeX, _lowRangeY, _highRangeY);
        //textRewardClone.transform.localPosition = randomVector;
        //textRewardClone.text = $"+{addedMuffins}";
    //}
}
// Rain Down Desserts
//int rainDesserts = _gameManager.AddMuffins();

    //________Create Array of Desserts__________

    //private void RainDessertsPrefab (int addedMuffins)
    //{
    // int length = _desserts.Length;                //length will be 25
    // int randomIndex = Random.Range(0, length);    //random range between 0-24
    // Texture2D randomTexture = _desserts[randomIndex];
    // image.texture = randomTexture;
    //}
    

//    //Random Position away from Muffin button      
//    Vector2 randomVector = MyToolbox.GetRandomVector2(_lowRangeX, _highRangeX, _lowRangeY, _highRangeY);
//    randomTexture.transform.localPosition = randomVector;

//    // Spawn Random Dessert
//    Spawn randomTexture.scale = 0.25f;
     
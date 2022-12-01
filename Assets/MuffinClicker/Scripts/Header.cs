using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Updates the Header children UI elements
/// // Always add XML documentation for anything that is Public
/// </summary>
public class Header : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _totalMuffinsText;

    //Call this Method from GameManager & tell this Method what the total Muffins is with parameters,
    //send data to this Method when we call it from the GameManager
    //This method needs to know it is receiving data, What is counter?
    //To create parameters you have to justify the parameters between the parathesis

    /// <summary>
    /// Updates the total muffins text.
    /// </summary>
    /// <param name="counter">The total muffins</param>

    public void UpdateTotalMuffins(int counter)
    {
        _totalMuffinsText.text = 
            counter ==1 ? 
            "1 muffin" : 
            $"{counter} muffin";
    }
}
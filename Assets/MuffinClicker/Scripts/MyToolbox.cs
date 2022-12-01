using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyToolbox 
{
   //We want a static method that will return a Vector2 with a random x and a random y position
    public static Vector2 GetRandomVector2(float _minX, float _maxX, float _minY, float _maxY)
    {
        // x -150 to 180
        // y -150 to 150
        
        Vector2 value = new Vector2();
      
        value.x = Random.Range(_minX, _maxX);
        value.y = Random.Range(_minY,_maxY);
        return value;
    } 
}

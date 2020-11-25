﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static Coord[] ShuffleCoords(Coord[] _dataArray)
    {
        for (int i = 0; i < _dataArray.Length; i++)
        {
            int randomNum = Random.Range(i, _dataArray.Length);

            Coord temp = _dataArray[randomNum];
            _dataArray[randomNum] = _dataArray[i];
            _dataArray[i] = temp;
        }
        return _dataArray;
    }
}

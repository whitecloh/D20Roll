using System.Collections.Generic;
using UnityEngine;

public class DicePositions
{
    /// <summary>
    /// Словарь углов поворота игральной кости(Ключ - число на грани , Значение - угол поворота)
    /// </summary>
    public Dictionary<int, Vector3> D20Value = new Dictionary<int, Vector3>
    {
        [1] = new Vector3(5, 10, -120),
        [2] = new Vector3(138, 12, -230),
        [3] = new Vector3(241, -116, -168),
        [4] = new Vector3(134, -270, -225),
        [5] = new Vector3(243, -250, -180),
        [6] = new Vector3(45, -255, -295),
        [7] = new Vector3(-58, 0, 0),
        [8] = new Vector3(-225, -15, -132),
        [9] = new Vector3(-45, -55, -135),
        [10] = new Vector3(-222, -54, -220),
        [11] = new Vector3(-140, 232, 322),
        [12] = new Vector3(-222, 50, 220),
        [13] = new Vector3(-142, -170, 52),
        [14] = new Vector3(-300, -180, 180),
        [15] = new Vector3(-405, 82, -130),
        [16] = new Vector3(62, -115, 170),
        [17] = new Vector3(-45, -80, 120),
        [18] = new Vector3(65, 105, 175),
        [19] = new Vector3(-135, 168, -50),
        [20] = new Vector3(180, 0, 180)
    };
}
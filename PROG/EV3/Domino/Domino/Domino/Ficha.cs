﻿namespace Domino
{
    public class Ficha
    {
        int _upperNum, _bottomNum;

        public bool IsDouble() => _upperNum == _bottomNum;
        public int GetSumNum() => _upperNum + _bottomNum;
    }
}

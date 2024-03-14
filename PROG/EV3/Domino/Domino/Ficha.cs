namespace Domino
{
    public class Ficha
    {
        int _upperNum, _bottomNum;

        public bool IsDouble => _upperNum == _bottomNum;
        public int SumNum => _upperNum + _bottomNum;

        public Ficha(int v1, int v2)
        {
            _upperNum = v1;
            _bottomNum = v2;
        }
    }
}

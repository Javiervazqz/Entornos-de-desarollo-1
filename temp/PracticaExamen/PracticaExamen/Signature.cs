using System;

namespace PracticaExamen
{
    public class Signature
    {
        public enum SignatureType
        {
            MATH = 0,
            HISTORY = 1,
            SCIENCE = 2,
            LANGUAGE = 3
        }
        public Signature()
        {
            
        }
        private double _mark;
        int signatureCount = Enum.GetNames(typeof(SignatureType)).Length;
        string[] a = Enum.GetNames(typeof(SignatureType));
        private SignatureType _signature;

        public int GetSignatureCount() => signatureCount;
        public double GetMark() => _mark;
        public void SetMark(double value) => _mark = value;
        public SignatureType GetSignature() => _signature;
    }
}

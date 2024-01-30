using System;

namespace PracticaExamen
{
    public class Signature
    {
        public enum SignatureType
        {
            MATH,
            HISTORY,
            SCIENCE,
            LANGUAGE
        }
        public Signature()
        {
            
        }
        private double _mark;
        private SignatureType _signature;
        int signatureCount = Enum.GetNames(typeof(SignatureType)).Length;
        string[] a = Enum.GetNames(typeof(SignatureType));
        public int GetSignatureCount() => signatureCount;
        public double GetMark() => _mark;
        public void SetMark(double value) => _mark = value;
        public SignatureType GetSignature() => _signature;
    }
}

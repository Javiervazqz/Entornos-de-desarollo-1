using System;

namespace Mierdon256
{
    public class Inspector : Director
    {
        public override string GetFullName()
        {
            return "<INSPECTOR>" + base.GetFullName() + "</INSPECTOR>";
        }
    }
}

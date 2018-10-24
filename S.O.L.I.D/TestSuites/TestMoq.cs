using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.TestSuites
{

    public class MoqMain
    {
        public bool flag;
        protected ITestMoq _iTestMoq;
        public MoqMain(ITestMoq iTestMoq)
        {
            _iTestMoq = iTestMoq;
        }

        public bool MyMethod()
        {
            return _iTestMoq.IsTrueFalse(flag);
        }

    }

    public class TestMoq : ITestMoq
    {
        public bool IsTrueFalse(bool flag)
        {
            return flag;
        }
    }

    public interface ITestMoq
    {
        bool IsTrueFalse(bool flag);
    }
}

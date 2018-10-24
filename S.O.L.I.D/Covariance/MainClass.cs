using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.Covariance
{
    class MainClass
    {
        public delegate BaseCovariance CovarianceDelegate(DerivedCovariance baseCovariance);

        static BaseCovariance BaseMethod(DerivedCovariance derCov)
        {
            return new BaseCovariance();
        }

        static DerivedCovariance DerivedMethod(BaseCovariance baseCov)
        {
            return new DerivedCovariance();
        }

        CovarianceDelegate covDel = BaseMethod;

    }
}

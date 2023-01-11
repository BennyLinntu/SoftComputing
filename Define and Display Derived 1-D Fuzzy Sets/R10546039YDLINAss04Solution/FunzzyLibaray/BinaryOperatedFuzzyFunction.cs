using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunzzyLibaray
{
    public class BinaryOperatedFuzzyFunction : FuzzyFunctions
    {
        // data fileds
        static int currentindex = 1;
        BinaryOperator bo;
        FuzzyFunctions ffca;
        FuzzyFunctions ffcb;
        // Properties


        // functions
        public BinaryOperatedFuzzyFunction(BinaryOperator bo, FuzzyFunctions ffca, FuzzyFunctions ffcb) : base(ffca.U)
        {
            this.bo = bo;
            this.ffca = ffca;
            this.ffcb = ffcb;
            ffca.UniverseParametersChanged += ffcParameterChanged;
            ffcb.UniverseParametersChanged += ffcParameterChanged;
            bo.parameterchanged += ffcParameterChanged;
            Name = $"{bo.Name}{currentindex++}{ffca.Name}{ffcb.Name}";

        }
        protected void ffcParameterChanged(object sender, EventArgs e)
        {
            Name = $"{bo.Name}{currentindex}{ffca.Name}{ffcb.Name}";
            GenerateSeries();

        }

        public override double GetValue(double x)
        {
            return bo.GetValue(ffca.GetValue(x), ffcb.GetValue(x));
        }


    }
}

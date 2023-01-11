using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunzzyLibaray
{
    public class UnaryOperatedFuzzyFunction : FuzzyFunctions
    {

        FuzzyFunctions ffc;
        public UnaryOperator uo;
        static int currentindex = 1;


        public UnaryOperatedFuzzyFunction(UnaryOperator uo, FuzzyFunctions ffc) : base(ffc.U)
        {
            this.uo = uo;
            this.ffc = ffc;
            ffc.UniverseParametersChanged += ffcParameterChanged;
            uo.parameterchaged += ffcParameterChanged;
            Name = $"{uo.Name}{currentindex++}{ffc.Name}";
            
        }
        public UnaryOperatedFuzzyFunction(UnaryOperator uo, FuzzyFunctions ffc, bool check) : base(ffc.U)
        {
            this.uo = uo;
            this.ffc = ffc;
        }


        protected void ffcParameterChanged(object sender, EventArgs e)
        {
            Name = $"{uo.Name}{currentindex}{ffc.Name}";
        }


        public override double GetValue(double x)
        {
            return uo.GetValue(ffc.GetValue(x));
        }


    }
}

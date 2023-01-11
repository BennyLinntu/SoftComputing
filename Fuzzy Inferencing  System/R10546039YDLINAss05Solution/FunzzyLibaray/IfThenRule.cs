using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public class IfThenRule
    {
        // data fileds
        List<FuzzyFunctions> ffcs = new List<FuzzyFunctions>();
        List<FuzzyFunctions> list = new List<FuzzyFunctions>();
        FuzzyFunctions ffc;
        UnaryOperatedFuzzyFunction uoff;
        int count;
        double min;

        // properites


        // functions
        public IfThenRule(List<FuzzyFunctions> ffcs, FuzzyFunctions ffc)
        {
            this.ffcs = ffcs;
            this.ffc = ffc;

            min = ffc.maxdegree;
            count = ffcs.Count;

            UnaryOperator uo = new ValueCutOperate();
            uoff = new UnaryOperatedFuzzyFunction(uo, ffc);
        }

        public UnaryOperatedFuzzyFunction FuzzyInFuzzyOutInferening(List<FuzzyFunctions> c, bool cutornot)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(c[i] & ffcs[i]);
            }
            for (int i = 0; i < count; i++)
            {
                if(list[i].maxdegree < min)
                {
                    min = list[i].maxdegree;
                }
            }
            if(cutornot == true)
            {
                uoff = min - ffc;
            }
            else
            {
                uoff = min * ffc;
            }
            uoff.SetSeries(Color.FromArgb(100, Color.LightSkyBlue), SeriesChartType.Area);

            return uoff;
        }

    }
}

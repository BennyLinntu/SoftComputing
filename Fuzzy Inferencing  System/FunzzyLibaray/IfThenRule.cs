using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public class IfThenRule
    {
        // data fileds
        FuzzyFunctions[] antecedent;
        List<int> antecedenthashcode = new List<int>();


        List<FuzzyFunctions> intersecting = new List<FuzzyFunctions>();
        FuzzyFunctions conclusionfs;
        UnaryOperatedFuzzyFunction result;
        int count;
        double min;

        public FuzzyFunctions[] Antecedent { get => antecedent; set => antecedent = value; }
        public FuzzyFunctions Conclusionfs { get => conclusionfs; set => conclusionfs = value; }

        // properites


        // functions
        public IfThenRule(List<FuzzyFunctions> antecedent, FuzzyFunctions ffc)
        {
            this.antecedent = new FuzzyFunctions[antecedent.Count];
            this.antecedent = antecedent.ToArray();
            this.conclusionfs = ffc;

            min = ffc.maxdegree;
            count = antecedent.Count;

            UnaryOperator uo = new ValueCutOperate(0.5);
            result = new UnaryOperatedFuzzyFunction(uo, ffc);
        }

        public UnaryOperatedFuzzyFunction FuzzyInFuzzyOutInferening(List<FuzzyFunctions> condition, bool cutornot)
        {
            for (int i = 0; i < count; i++)
            {
                intersecting.Add(condition[i] & intersecting[i]);
            }
            for (int i = 0; i < count; i++)
            {
                if(intersecting[i].maxdegree < min)
                {
                    min = intersecting[i].maxdegree;
                }
            }
            if(cutornot == true)
            {
                ValueCutOperate c = new ValueCutOperate();
                result = new UnaryOperatedFuzzyFunction(c, conclusionfs);
            }
            else
            {
                result = min * conclusionfs;
            }
            result.SetSeries(Color.FromArgb(100, Color.LightSkyBlue), SeriesChartType.Area);

            return result;
        }
        



        public double GetMinDegree(double[] inputs)
        {
            double minantecedent = double.MaxValue;
            for (int i = 0; i < antecedent.Length; i++)
            {
                for (int j = 0; j < inputs.Length; j++)
                {
                    if(antecedent[i].GetValue(inputs[j]) <= minantecedent)
                    {
                        minantecedent = antecedent[i].GetValue(inputs[i]);
                    }
                }
            }
            return minantecedent;
        }
        public FuzzyFunctions GetInferenceFuzzySet(double[] inputs, bool cutornot)
        {
            FuzzyFunctions result = null;
            double minantecedent = GetMinDegree(inputs);
            ValueCutOperate c = new ValueCutOperate();
            result = new UnaryOperatedFuzzyFunction(c, conclusionfs, true);
            return result;
        }

    }

    // Mandani If Then Fuzzy Rule
    public class MandaniIfThenFuzzyRule
    {
        // data field
        FuzzyFunctions[] antecedent;
        FuzzyFunctions ffc;
        List<int> ffsum = new List<int>();
        List<FuzzyFunctions> ffcs = new List<FuzzyFunctions>();
        UnaryOperatedFuzzyFunction uoff;
        int hashcode;
        int count;
        double min;
        // properties
        public FuzzyFunctions[] Antecedent { get => antecedent; set => antecedent = value; }
        public FuzzyFunctions Ffc { get => ffc; set => ffc = value; }
        public List<int> Ffsum { get => ffsum; set => ffsum = value; }
        public List<FuzzyFunctions> Ffcs { get => ffcs; set => ffcs = value; }
        public UnaryOperatedFuzzyFunction Uoff { get => uoff; set => uoff = value; }
        public int Hashcode { get => hashcode; set => hashcode = value; }
        public int Count { get => count; set => count = value; }
        // functions     
        public MandaniIfThenFuzzyRule(List<FuzzyFunctions> ffs, FuzzyFunctions ffc)
        {
            this.Antecedent = new FuzzyFunctions[Ffcs.Count];
            this.Antecedent = Ffcs.ToArray();
            this.Ffc = ffc;

            min = ffc.maxdegree;
            Count = ffs.Count;

            UnaryOperator uo = new ValueCutOperate();
            Uoff = new UnaryOperatedFuzzyFunction(uo, ffc);

        }
        public UnaryOperatedFuzzyFunction FuzzyInFuzzyOutInferencing(List<FuzzyFunctions> conditions, bool cutornot)
        {
            for (int i = 0; i < Count; i++)
            {
                Ffcs.Add(Antecedent[i] & conditions[i]);
            }
            for (int i = 0; i < Count; i++)
            {
                if (Ffcs[i].maxdegree < min)
                {
                    min = Ffcs[i].maxdegree;
                }
            }
            // cut
            if (cutornot == true)// here means cut
            {
                ValueCutOperate bco = new ValueCutOperate(min);
                Uoff = new UnaryOperatedFuzzyFunction(bco, Ffc, true);
            }
            else
            {
                Uoff = min * Ffc;
            }
            uoff.SetSeries(Color.FromArgb(128, Color.Gray), SeriesChartType.Area);
            return Uoff;
        }
        public double GetMinDegree(double[] input)
        {
            double minofnum = double.MaxValue;
            for (int i = 0; i < Antecedent.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (Antecedent[i].GetValue(input[j]) <= minofnum)
                    {
                        minofnum = Antecedent[i].GetValue(input[j]);
                    }

                }
            }
            return minofnum;
        }

        public FuzzyFunctions GetInferencedFuzzySet(double[] input, bool cutornot)
        {
            FuzzyFunctions ffc = null;
            double minofnum = GetMinDegree(input);
            ValueCutOperate vco = new ValueCutOperate(minofnum);
            return new UnaryOperatedFuzzyFunction(vco, ffc, true);
        }
        // Save 
        internal void SaveModel(StreamWriter sw)
        {
            sw.WriteLine($"Number of Rules: {Antecedent.Length}");
            foreach (var item in Antecedent)
            {
                sw.WriteLine($"Antcedent: {item.GetHashCode()}");
            }
            sw.WriteLine($"Conclusion: {Ffc.GetHashCode()}");
        }
        // Read
        internal void ReadModel(StreamReader sr)
        {
            int num;
            string str = sr.ReadLine().Trim();
            num = int.Parse(str.Substring(str.IndexOf(':') + 1));
            Ffsum.Clear();
            for (int i = 0; i < num; i++)
            {
                str = sr.ReadLine().Trim();
                Ffsum.Add(int.Parse(str.Substring(str.IndexOf(':') + 1)));

            }
            str = sr.ReadLine().Trim();
            Hashcode = int.Parse(str.Substring(str.IndexOf(':') + 1));

        }


    }

    // Sugeon if then  Fuzzy rule
    public class SugeonIfThenFuzzyRule
    {
        // data fields
        FuzzyFunctions[] antecedent;
        int id;

        // properties
        public FuzzyFunctions[] Antecedent { get => antecedent; set => antecedent = value; }
        public int Id { get => id; set => id = value; }
        // functions
        public SugeonIfThenFuzzyRule(List<FuzzyFunctions> antecedent, int id)
        {
            this.Antecedent = new FuzzyFunctions[antecedent.Count];
            this.Antecedent = antecedent.ToArray();
            this.Id = id;
        }

        public static double GetOutPutValue(double[] input, int id)
        {
            if (id == 0)
            {
                return 0.1 * input[0] + 6.3;
            }
            else if (id == 1)
            {
                return -0.5 * input[0] + 4;
            }
            else if (id == 2)
            {
                return input[0] - 2;
            }
            else if (id == 3)
            {
                return -input[1] + 3;
            }
            else if (id == 4)
            {
                return -input[0] + 3;
            }
            else
            {
                return input[0] + input[1] + 2;
            }
        }
        public double GetMinWeight(double[] inputs)
        {
            double[] weights = new double[Antecedent.Length];
            for (int i = 0; i < Antecedent.Length; i++)
            {
                weights[i] = Antecedent[i].GetValue(inputs[i]);
            }
            return weights.Min();
        }
        public double GetY(double[] inputs)
        {
            return GetOutPutValue(inputs, Id);
        }

    }
    // Tsukamoto if then rule Fuzzy System
    public class TsukamotoIfThenFuzzyRule
    {
        // data fields
        FuzzyFunctions[] antecedent;
        FuzzyFunctions conclusion;
        // properties
        public FuzzyFunctions[] Antecedent { get => antecedent; set => antecedent = value; }
        public FuzzyFunctions Conclusion { get => conclusion; set => conclusion = value; }

        // functions
        public TsukamotoIfThenFuzzyRule(List<FuzzyFunctions> antecedent, FuzzyFunctions conclusion)
        {
            this.antecedent = new FuzzyFunctions[antecedent.Count];
            this.antecedent = antecedent.ToArray();
            this.conclusion = conclusion;
        }

        public double GetMinWeight(double[] inputs)
        {
            double[] weights = new double[antecedent.Length];
            for (int i = 0; i < antecedent.Length; i++)
            {
                weights[i] = antecedent[i].GetValue(inputs[i]);
            }
            return weights.Min();
        }
        public double GetZ(double weight)
        {
            return conclusion.GetValue(weight);
        }

       
    }




}

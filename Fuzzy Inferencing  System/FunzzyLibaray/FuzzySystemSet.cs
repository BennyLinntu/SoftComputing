using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunzzyLibaray
{
    public class FuzzySystemSet
    {
        public FuzzySystemSet()
        {

          
        }
        
    }
    public enum Defuzzification
    {
        COA, BOA, MOM, SOM, LOM
    }
    // Mandani Fuzzy ystem
    public class MandaniFuzzySystem : FuzzySystemSet
    {
        // data field
        List<FuzzyFunctions> result = new List<FuzzyFunctions>();
        List<MandaniIfThenFuzzyRule> rules = new List<MandaniIfThenFuzzyRule>();
        FuzzyFunctions ffc = null;
        bool cutornot = true;
        // properties
        public List<MandaniIfThenFuzzyRule> Rules 
        {
            get => rules;
            set => rules = value; 
        }
        public bool Cutornot 
        { 
            get => cutornot; 
            set => cutornot = value; 
        }
        public Defuzzification dt
        {
            set;
            get;
        } = Defuzzification.COA; // defult will be the COA
        // functions
        public MandaniFuzzySystem()
        {

        }
        public void Update_Rule_Sets(List<MandaniIfThenFuzzyRule> rules)
        {
            this.rules = rules;
        }
        // Crisp In Fuzzy Out
        public FuzzyFunctions CrispInFuzzyOutInferencing(double[] location)
        {
            result.Clear();
            for (int ki = 0; ki < rules.Count; ki++)
            {
                result.Add(rules[ki].GetInferencedFuzzySet(location, cutornot));
            }
            for (int i = 0; i < rules.Count; i++)
            {
                if(i == 0)
                {
                    ffc = result[0];
                }
                ffc = ffc | result[i];
                
            }
            return ffc;
        }
        //Crisp In Crisp Out
        public double CrispInCrispOutInferencing(double[] location, bool cutornot)
        {
            this.cutornot = cutornot;
            FuzzyFunctions ffc = CrispInFuzzyOutInferencing(location);
            switch (dt)
            {
                case Defuzzification.COA:
                    return ffc.COA;
                case Defuzzification.BOA:
                    return ffc.BOA;
                case Defuzzification.MOM:
                    return ffc.MOM;
                case Defuzzification.LOM:
                    return ffc.LOM;
                case Defuzzification.SOM:
                    return ffc.SOM;
                default:
                    return double.NaN;
            }
        }
        // save 
        public void SaveModel(StreamWriter sw)
        {
            sw.WriteLine($"Cut: {cutornot}");
            sw.WriteLine($"Fuzzy Type: {(int)dt}");
            sw.WriteLine($"Number of Rules: {rules.Count}");
            for (int i = 0; i <  rules.Count; i++)
            {
                rules[i].SaveModel(sw);
            }
        }
        // Open
        public void ReadModel(StreamReader sr)
        {
            string str = sr.ReadLine().Trim();
            cutornot = bool.Parse(str.Substring(str.IndexOf(':') + 1));
            str = sr.ReadLine().Trim();
            dt = (Defuzzification)(int.Parse(str.Substring(str.IndexOf(':') + 1)));

            str = sr.ReadLine().Trim();
            int num = int.Parse(str.Substring(str.IndexOf(':') + 1));
            for (int i = 0; i < num; i++)
            {
                rules[i].ReadModel(sr);
            }

        }


    }


    // Sugeon Fuzzy System
    public class SugeonFuzzySystem : FuzzySystemSet
    {
        // data fields
        SugeonIfThenFuzzyRule[] rules;
        // properties
        public SugeonIfThenFuzzyRule[] Rules { get => rules; set => rules = value; }

        // functions
        public SugeonFuzzySystem()
        {

        }

        public void UpdateRuleSets(List<SugeonIfThenFuzzyRule> rules)
        {
            this.rules = new SugeonIfThenFuzzyRule[rules.Count];
            this.rules = rules.ToArray();
        }
        public double CrispInCrispOutInferencing(double[] inputs)
        {
            double[] weights = new double[rules.Length];
            double[] y = new double[rules.Length];
            double weightTimey = 0;
            double weightResult;
            for (int j = 0; j < rules.Length; j++)
            {
                weights[j] = rules[j].GetMinWeight(inputs);
                y[j] = rules[j].GetY(inputs);
            }
            for (int i = 0; i < weights.Length; i++)
            {
                weightTimey += weights[i] * y[i]; 
            }
            weightResult = weightTimey / weights.Sum();
            return weightResult;
        }

    }

    



    // Tsukamoto Fuzzy System
    public class TsukamotoFuzzySystem : FuzzySystemSet
    {
        // data fields
        TsukamotoIfThenFuzzyRule[] rules;
        // properties
        public TsukamotoIfThenFuzzyRule[] Rules { get => rules; set => rules = value; }
        // functions
        
        public TsukamotoFuzzySystem()
        {

        }
        public void UpdateRulesSets (List<TsukamotoIfThenFuzzyRule> rules)
        {
            this.rules = new TsukamotoIfThenFuzzyRule[rules.Count];
            this.rules = rules.ToArray();
        }


        public double CrispInCrispOutInferencing(double[] inputs)
        {
            double[] weight = new double[rules.Length];
            double[] z = new double[rules.Length];
            double weighttime = 0;
            double weightresult;
            for (int i = 0; i < rules.Length; i++)
            {
                weight[i] = rules[i].GetMinWeight(inputs);
                z[i] = rules[i].GetZ(weight[i]);
            }
            for (int j = 0; j < weight.Length; j++)
            {
                weighttime += weight[j] * z[j];
            }
            weightresult = weighttime / weight.Sum();
            if(weight.Sum() == 0)
            {
                return 0;
            }
            else
            {
                return weightresult;
            }




        }
        
    }

    







}

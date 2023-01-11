using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunzzyLibaray
{
    public class BinaryOperator
    {

        // data fileds
        public event EventHandler parameterchanged;
        string name;

        // properties
        public string Name { get => name; set => name = value; }

        // functions
        public BinaryOperator()
        {

        }
        protected void ParameterChangedEvent()
        {
            if (parameterchanged == null)
            {
                return;
            }
            else
            {
                parameterchanged(this, null);
            }
        }
        public virtual double GetValue(double x, double y)
        {
            throw new Exception();
        }

    }
    // Intersection operator
    public class ValueIntersectionOperate : BinaryOperator
    {

        public ValueIntersectionOperate()
        {
            Name = "Value Intersection Operate";
        }

        public override double GetValue(double x, double y)
        {
            if (x <= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

    }
    //Union Operator
    public class ValueUnionOpeate : BinaryOperator
    {
        public ValueUnionOpeate()
        {
            Name = "Value Union Operate";
        }
        public override double GetValue(double x, double y)
        {
            if (x <= y)
            {
                return y;
            }
            else
            {
                return x;
            }

        }
    }
    // subtraction operator
    public class ValueSubtractionOperate : BinaryOperator
    {
        public ValueSubtractionOperate()
        {
            Name = "Value Substraction Operate";
        }
        public override double GetValue(double x, double y)
        {
            if (x <= y)
            {
                return y - x;
            }
            else
            {
                return x - y;
            }
        }
    }

    // Algebraic Product Operate
    public class ValueAlgebraicProductOperate : BinaryOperator
    {


        public ValueAlgebraicProductOperate()
        {
            Name = "Value Algebraic Product Operate";

        }
        public override double GetValue(double x, double y)
        {
            return x * y;
        }


    }
    // Algebraic Sum Operate
    public class ValueAlgebraicSumOperate : BinaryOperator
    {


        public ValueAlgebraicSumOperate()
        {
            Name = "Value Algebraic SumO perate";

        }
        public override double GetValue(double x, double y)
        {
            return (x + y - (x * y));
        }


    }



    // Value Dombi Torm Operate
    public class ValueDombiTormOperate : BinaryOperator
    {
        // data fileds
        double k = 1.0;
        public ValueDombiTormOperate()
        {
            Name = "Value Dombi TNorm";
        }

        public override double GetValue(double x, double y)
        {
            double a = Math.Pow(((1 / x) - 1), k);
            double b = Math.Pow(((1 / y) - 1), k);
            double c = Math.Pow((a + b), (1 / k));
            return 1.0 / (1 + c);

        }
    }
    // Value Bounded Product Operate
    public class ValueBoundedProductOperate : BinaryOperator
    {
        public ValueBoundedProductOperate()
        {
            Name = "Value Bounded Product Operate";
        }
        public override double GetValue(double x, double y)
        {
            return Math.Max(0, x + y - 1);
        }


    }
    // Value Bounded Sum Operate
    public class ValueBoundedSumOperate : BinaryOperator
    {
        public ValueBoundedSumOperate()
        {
            Name = "Value Bounded Sum Operate";
        }

        public override double GetValue(double x, double y)
        {
            return Math.Min(1, (x + y));
        }

    }

    // Value Logical Sum Operate
    public class ValueLogicalSumOperate : BinaryOperator
    {
        public ValueLogicalSumOperate()
        {
            Name = "Value Logical Sum Operate";
        }

        public override double GetValue(double x, double y)
        {
            if (x <= y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }

    }
    // Value Logical Product Operate
    public class ValueLogicalProductOperate : BinaryOperator
    {
        public ValueLogicalProductOperate()
        {
            Name = "Value Logical Product Operate";
        }

        public override double GetValue(double x, double y)
        {
            if (x <= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

    }
    // Value Drastic Product Operate
    public class ValueDrasticProductOperate : BinaryOperator
    {
        public ValueDrasticProductOperate()
        {
            Name = "Value Drastic Product Operate";
        }

        public override double GetValue(double x, double y)
        {
            if (x == 1.0)
            {
                return y;
            }
            else if (y == 1.0)
            {
                return x;
            }
            else
            {
                return 0.0;
            }
        }

    }
    // ValueDrasticSumOperate
    public class ValueDrasticSumOperate : BinaryOperator
    {
        public ValueDrasticSumOperate()
        {
            Name = "Value Drastic Sum Operate";
        }

        public override double GetValue(double x, double y)
        {
            if (x == 0.0)
            {
                return y;
            }
            else if (y == 0.0)
            {
                return x;
            }
            else
            {
                return 1.0;
            }
        }

    }

    // Value Einstein Sum Operate
    public class ValueEinsteinSumOperate : BinaryOperator
    {
        public ValueEinsteinSumOperate()
        {
            Name = "Value Einstein Sum Operate";
        }

        public override double GetValue(double x, double y)
        {
            return (x + y) / (1.0 + x * y);
        }

    }
    // Value Einstein Product Operate
    public class ValueEinsteinProductOperate : BinaryOperator
    {
        public ValueEinsteinProductOperate()
        {
            Name = "Value Einstein Product Operate";
        }

        public override double GetValue(double x, double y)
        {
            return (x + y) / (2.0 - (x + y - (x * y)));
        }

    }
    //Valu eHamacher S Norm Operate
    public class ValueHamacherSNormOperate : BinaryOperator
    {
        public ValueHamacherSNormOperate()
        {
            Name = "Valu eHamacher S Norm Operate";
        }

        public override double GetValue(double x, double y)
        {
            return (x + y - 2.0 * x * y) / (1.0 - x * y);
        }

    }
    //Valu eHamacher T Norm Operate
    public class ValueHamacherTNormOperate : BinaryOperator
    {
        public ValueHamacherTNormOperate()
        {
            Name = "Valu eHamacher T Norm Operate";
        }

        public override double GetValue(double x, double y)
        {
            if (x != 0.0 && y != 0.0)
            {
                return (x * y) / (x + y + (x * y));
            }
            else
            {
                return 0.0;
            }
        }

    }



}

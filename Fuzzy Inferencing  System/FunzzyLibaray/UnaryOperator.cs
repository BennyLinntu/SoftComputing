using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunzzyLibaray
{
    public class UnaryOperator
    {
        // data fileds
        //double[] parameters;
        public event EventHandler parameterchaged; // event
        string name;
        // properties

        public string Name { get => name; set => name = value; }

        // functions
        public UnaryOperator()
        {

        }
        protected void ParameterChangedEvent()
        {
            if(parameterchaged == null)
            {
                return;
            }
            else
            {
                parameterchaged(this, null);
            }
        }
        public virtual double GetValue(double x)
        {
            throw new Exception();
        }
    }

    // here we set Unary class

    //value cut operator
    public class ValueCutOperate : UnaryOperator
    {
        // data fileds
        double cutvalue = 0.5;
        // properties
        public double Cutvalue 
        { 
            get => cutvalue;
            set
            {
                if(value >0 && value <= 1)
                {
                    cutvalue = value;
                    ParameterChangedEvent();
                }
            }
        }
        public ValueCutOperate(double cutnum)
        {
            cutvalue = cutnum;
            Name = "Value Cut Operate";
        }
        // here is functions
        public ValueCutOperate()
        {
            Name = "Value Cut Operate";
        }

        public override double GetValue(double x)
        {
            if(x > cutvalue)
            {
                return cutvalue;
            }
            else
            {
                return x;
            }
        }

    }

    // Value Scale Operator
    public class ValueScaleOperate : UnaryOperator
    {
        // data fileds
        double scalevalue = 0.5;
        // Properties

        public double Scalevalue
        {
            get => scalevalue;
            set
            {
                if(scalevalue > 0)
                {
                    scalevalue = value;
                    ParameterChangedEvent();
                }
            }
        }

        //functions
        public ValueScaleOperate()
        {
            Name = "Value Scale Operate";
        }
        public override double GetValue(double x)
        {
            return Math.Pow(x, (1.0 / scalevalue));
        }



    }
    // Negate Operator
    public class ValueNegativeOperate : UnaryOperator
    {
        public ValueNegativeOperate()
        {
            Name = "Value Negative Operate";
        }
        public override double GetValue(double x)
        {
            return 1 - x;
        }


    }
    // Very Operator

    public class ValueConcentrationOperate : UnaryOperator
    {
        // data fileds
        double veryvalue = 2;
        // properities
        public double Veryvalue
        {
            get => veryvalue; 
            set
            {
                if (value >= 2 && value < 8)
                {
                    veryvalue = value;
                }
                else
                {
                    return;
                }
            }
        }
        public ValueConcentrationOperate()
        {
            Name = "Value Very Operate";
        }
        public override double GetValue(double x)
        {
            return Math.Pow(x, veryvalue);
        }
    }

    // Extremely Operator
    public class ValueExtremelyOperate : UnaryOperator
    {
        // data fileds
        double extremelyvalue = 8;

        // properities
        public double Extremelyvalue
        { 
            get => extremelyvalue; 
            set
            {
                if( value >= 8)
                {
                     extremelyvalue = value;
                }
                else
                {
                    return;
                }
            }
        }

        public ValueExtremelyOperate()
        {
            Name = "Value Extremely Operate";
        }


        public override double GetValue(double x)
        {
            return Math.Pow(x, extremelyvalue);
        }
    }

    // Diminish Operator

    public class VlaueDiminishOperate : UnaryOperator
    {
        public VlaueDiminishOperate()
        {
            Name = "Vlaue Diminish Operate";
        }
        public override double GetValue(double x)
        {
            if(0 <= x && x <= 0.5)
            {
                return Math.Pow(x * 0.5, 0.5);
            }
            else
            {
                return 1 - (Math.Pow((1 - x) * 0.5, 0.5));
            }
        }
    }

    // Value Intensification Operate
    public class ValueIntensificationOperate : UnaryOperator
    {

        public ValueIntensificationOperate()
        {
            Name = "Value Intensification Operate";
        }
        public override double GetValue(double x)
        {
            if (0 <= x && x <= 0.5)
            {
                return 2 * (Math.Pow(x, 2));
            }
            else
            {
                return 1 - (2 * (Math.Pow(x, 2)));
            }
        }

    }



}

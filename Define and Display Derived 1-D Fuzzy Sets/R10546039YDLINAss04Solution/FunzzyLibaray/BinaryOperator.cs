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
            if(parameterchanged == null)
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
            if(x <= y)
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
            if( x <= y)
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
            if(x <= y)
            {
                return y - x;
            }
            else
            {
                return x - y;
            }
        }
    }
    




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
/*    Bài tập 1:Viết một lớp Calculator sẽ chấp nhận hai giá trị làm đối số, sau đó cộng, trừ , nhân hoặc chia chúng theo yêu cầu.

For example :
var mycalc = new MyCalculator(12, 6);
-> nhan() chia() ....

*/
    public class Calculator
    {
        private double _arg1 { get; set; }
        private double _arg2 { get; set; }

        public Calculator(double arg1, double arg2) { 
            _arg1 = arg1;
            _arg2 = arg2;
        }

        public Calculator()
        {   
        }

        public double Add()
        {
            return _arg1 + _arg2;
        }

        public double Subtract()
        {
            return _arg1 - _arg2;
        }

        public double Multiply()
        {
            return _arg1 * _arg2;
        }
        public double Divide()
        {
            if (_arg2 == 0) { 
                  throw new DivideByZeroException("Cannot divide by zero");
            }
            return _arg1 / _arg2;
        }

    }
}

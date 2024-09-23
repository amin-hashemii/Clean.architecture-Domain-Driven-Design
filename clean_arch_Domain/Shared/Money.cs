using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.Shared
{
    public class Money :BaseValueObject
    {
        public int Value { get;}
        public Money(int rialValue)
        {
            if (rialValue < 0)
                throw new InvalidDataException();
            Value = rialValue;
        }
        public static Money fromRial(int value)
        {
            return new Money(value);
        }
        public static Money fromToman(int value)
        {
            return new Money(value*10);
        }
        public override string ToString()
        {
            return Value.ToString("#,0");
        }
        public static Money operator + (Money firstMoney, Money Money2)
        {
            return new Money(firstMoney.Value + Money2.Value);
        }
        public static Money operator -(Money firstMoney, Money Money2)
        {
            return new Money(firstMoney.Value - Money2.Value);
        }
    }
}

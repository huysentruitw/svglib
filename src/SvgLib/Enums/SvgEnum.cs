using System.Collections.Generic;

namespace SvgLib
{
    public abstract class SvgEnum
    {
        private readonly string _value;

        protected SvgEnum(string value)
        {
            _value = value;
        }
        
        public override string ToString() => _value;

        public static implicit operator string(SvgEnum value) => value.ToString();

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;
            return _value == ((SvgEnum)obj)._value;
        }

        public override int GetHashCode()
        {
            var hashCode = -862051595;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_value);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetType().Name);
            return hashCode;
        }
    }
}

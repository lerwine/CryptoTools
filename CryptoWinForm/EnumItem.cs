using System;
using System.ComponentModel;
using System.Linq;

namespace CryptoWinForm
{
    [DataObject]
    [Serializable]
    public class EnumItem<T>
    {
        private readonly T _value;
        private readonly string _name;
        private readonly string _display;

        [DataObjectField(false, false, true)]
        public T Value { get { return _value;  } }

        [DataObjectField(true, false, false)]
        public string Name { get { return _name; } }

        [DataObjectField(false, false, false)]
        public string Display { get { return _display; } }

        public EnumItem(T value, string display)
        {
            this._value = value;
            this._name = (null == value) ? "" : Enum.GetName(value.GetType(), value);
            this._display = (null == display) ? ((null == value) ? "(none)" : this._name) : display;
        }

        public static EnumItem<T>[] Create()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().Select(t => new EnumItem<T>(t, null)).ToArray();
        }
    }
}
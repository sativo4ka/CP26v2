using System;
using System.Collections.Generic;
using System.Text;

namespace CP26v2
{
    public class ValueCache<T> where T : struct
    {
        private T? value;

        public bool TryGet(out T? value)
        {
            value = this.value;
            return value.HasValue;
        }

        public void Set(T value)
        {
            this.value = value;
        }

        public void Clear()
        {
            value = null;
        }
    }
}

using System;

namespace CounterModel
{
    public class Counter
    {
        int value = 0;
        const int MaxValue = 999;

        public void Increase()
        {
            if (value == MaxValue)
            {
                value = 0;
            }
            else
            {
                value = value + 1;
            }            
        }
        public void Decrease()
        {
            if (value == 0)
            {
                value = MaxValue;
            }
            else
            {
                value = value - 1;
            }
        }
        public void Reset()
        {
            value = 0;
        }
        public void ResetToMax()
        {
            value = MaxValue;
        }
        public string GetValue()
        {
            string text = value.ToString();
            while (text.Length < 3)
            {
                text = "0" + text;
            }
            return text;
        }
    }
}

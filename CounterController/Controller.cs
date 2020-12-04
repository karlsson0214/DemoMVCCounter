using System;
using System.Collections.Generic;
using System.Text;
using CounterModel;
using ViewInterface;

namespace WpfCounterController
{
    public class Controller
    {
        // model in MVC
        private Counter counter = new Counter();
 
        public void Increase(ICounterView view)
        {
            counter.Increase();
            view.SetNumber(counter.GetValue());         
        }
        public void Decrease(ICounterView view)
        {
            counter.Decrease();
            view.SetNumber(counter.GetValue());
        }
        public void Reset(ICounterView view)
        {
            counter.Reset();
            view.SetNumber(counter.GetValue());
        }
        public void ResetToMax(ICounterView view)
        {
            counter.ResetToMax();
            view.SetNumber(counter.GetValue());
        }
    }
}

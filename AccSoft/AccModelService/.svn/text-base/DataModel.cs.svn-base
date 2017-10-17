using System;
using System.Collections.Generic;
using System.Text;

namespace AccModelService
{
    public abstract class DataModel
    {
        private List<IView> viewers;

        public DataModel()
        {
            viewers = new List<IView>();
        }

        public void Attach(IView v)
        {
            viewers.Add(v);
        }

        public void Detach(IView v)
        {
            viewers.Remove(v);
        }

        public void Notify()
        {
            foreach (IView v in viewers)
                v.UpdateView();
        }
    }
}

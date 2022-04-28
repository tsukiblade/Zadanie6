using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6.Base
{
    public class AllPropertiesChangedEventArgs : PropertyChangedEventArgs
    {
        public AllPropertiesChangedEventArgs()
            : base(null)
        { }
    }
}

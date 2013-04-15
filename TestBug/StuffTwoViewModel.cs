using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.Diagnostics;

namespace TestBug
{
    class StuffTwoViewModel : PropertyChangedBase
    {
        public StuffTwoViewModel()
        {
            Debug.WriteLine( "2 constructor" );
        }
    }
}

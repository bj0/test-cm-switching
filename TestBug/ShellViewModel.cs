using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.Diagnostics;

namespace TestBug
{
    class ShellViewModel : PropertyChangedBase
    {
        StuffOneViewModel vm1;
        StuffTwoViewModel vm2;

        private object _Current;
        public object Current
        {
            get { return _Current; }
            set
            {
                if( value != _Current )
                {
                    _Current = value;
                    NotifyOfPropertyChange( () => Current );
                }
            }
        }

        public void First()
        {
            Current = vm1;
            Debug.WriteLine( "one" );
        }

        public void Second()
        {
            Current = vm2;
            Debug.WriteLine( "two" );
        }

        public ShellViewModel()
        {
            vm1 = new StuffOneViewModel();
            vm2 = new StuffTwoViewModel();
        }
    }
}

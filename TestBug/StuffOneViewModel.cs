using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.Diagnostics;

namespace TestBug
{
    class StuffOneViewModel : PropertyChangedBase
    {
        public enum Values
        {
            One, Two, Three
        }

        private Values _CurrentValue;
        public Values CurrentValue
        {
            get { return _CurrentValue; }
            set
            {
                if( value != _CurrentValue )
                {
                    _CurrentValue = value;
                    NotifyOfPropertyChange( () => CurrentValue );

                    Debug.WriteLine( "cv = {0}", CurrentValue );
                }
            }
        }

        public StuffOneViewModel() : base()
        {
            Debug.WriteLine( "1 constructor" );
        }
        
    }
}

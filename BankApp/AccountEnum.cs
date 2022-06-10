using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class AccountEnum :IEnumerator
    {
        public List<string> _account=new List<string>();

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.

        int position = -1;

        public AccountEnum() { }
        public AccountEnum(string firstname,string lastname)
        {
            _account.Add(firstname);
            _account.Add(lastname);
        }

        public bool MoveNext()
        {
            position++;
            return (position < _account.Count());
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public string Current
        {
            get
            {
                try
                {
                    return _account[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}

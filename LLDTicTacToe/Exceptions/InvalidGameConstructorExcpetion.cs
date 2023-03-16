using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Exceptions
{
    public class InvalidGameConstructorExcpetion : Exception
    {
        public InvalidGameConstructorExcpetion(string message) : base(message)
        {
        }
    }
}

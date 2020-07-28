using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace DependencyInjection
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol", '+')]
    class Add : IOperation
    {
        public int Operate(int left, int right)
        {
            return left + right;
        }
    }
}

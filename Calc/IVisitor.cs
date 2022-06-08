﻿using Calc.SyntaxNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public interface IVisitor
    {
        void Visit(ArithmeticOperation operation);

        void Visit(Constant constant);
    }
}

using System.IO;
using System;
using Calc.SyntaxNodes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc {
  public class LogInterpreter : Interpreter, IDisposable
  {
    public StreamWriter _logWriter = new StreamWriter("log.txt");

    public void Dispose(){
      Dispose(_logWriter);
    }

    public override void Visit(ArithmeticOperation operation)
    {
      _logWriter.Writeline(operation.ToString());
    } 

    public override void Visit(Constant constant){
      _logWriter.WriteLine(constant.ToString());
    }
  } 
}
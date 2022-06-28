using System.Configuration;

namespace Calc
{
  public class InterpreterFactory
  {
    public Interpreter CreateInterpreter()
    {
      if (ConfigurationManager.AppSettings["log"] == "True")
      {
        return new LogInterpreter();
      } else {
        return new Interpreter();
      }
    }
  }
}
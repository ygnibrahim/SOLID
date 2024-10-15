

using Solid.App;
using Solid.App.OCPGood;
using static Solid.App.OCPBad.OCPBad;
using static Solid.App.OCPGood.OCPGood;

//Console.WriteLine("Hello, World!");

//SalaryCalculator ocp = new();


//Bad way
//Console.WriteLine($"Low Salary:{oCPBad.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle Salary:{oCPBad.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High Salary: {oCPBad.Calculate(1000, SalaryType.High)} ");

//Good way
//Console.WriteLine($"Low Salary:{ocp.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle Salary:{ocp.Calculate(1000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"High Salary: {ocp.Calculate(1000, new HighSalaryCalculate())} ");
//Console.WriteLine($"High Salary: {ocp.Calculate(1000, new ManagerCalculate())} ");


BasePhone obj=new IPhone();

obj.TakePhoto();
obj.Call();

BasePhone obj2 = new Nokia();
obj2.Call();

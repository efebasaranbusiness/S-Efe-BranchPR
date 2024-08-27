using S_Efe_BranchPR;

Console.WriteLine("Please Enter a Number...");
int UserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number to Predict?");
int CatchNumber = Convert.ToInt32(Console.ReadLine());

if (UserNumber == CatchNumber)
{
    Console.WriteLine("The Result is Correct Here is Your Information\n");
    XMethodClass xMethodClass = new XMethodClass();
    xMethodClass.GetUserData();
}
else
{
    Console.WriteLine("your guess is wrong!");
    FalseMethod falseMethod = new FalseMethod();    
    falseMethod.GetData();
}

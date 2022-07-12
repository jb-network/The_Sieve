using The_Sieve;

int UserChoice;
do
{
    Console.WriteLine("Welcome to The Sieve number validator");
    Console.WriteLine("You can pick from the following number filters for checking numbers");
    Console.WriteLine("1 - Even Number");
    Console.WriteLine("2 - Positive Number");
    Console.WriteLine("3 - Multiple of Ten Uumber");
    UserChoice = Convert.ToInt32(Console.ReadLine());
    if (UserChoice != 1 && UserChoice != 2 && UserChoice != 3) Console.WriteLine("Please try again, your selection was not valid");
} while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);


Sieve NumberTester = UserChoice switch
{
    1 => new Sieve(EvenNumber),
    2 => new Sieve(PositiveNumber),
    3 => new Sieve(MultipleNumber)
};

while (true)
{
    Console.Write("Please provide a number to test: ");
    int UserProvidednumber = Convert.ToInt32(Console.ReadLine());
    
    bool NumberTest = NumberTester.IsGood(UserProvidednumber);
    if (NumberTest == true) Console.WriteLine($"The number {UserProvidednumber} that you provided passed our test.  This is a good number");
    else Console.WriteLine($"The number {UserProvidednumber} that you provided failed out test. This is a bad number");
}

//Local Methods
bool EvenNumber(int number)
{
    return number % 2 == 0;
}

bool PositiveNumber(int number)
{
    return number > 0;
}

bool MultipleNumber(int number)
{
    return number % 10 == 0;
}
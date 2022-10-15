Random ans = new Random();
int randomAns = ans.Next(1, 100);
int num;
int round = 0;
int limit = 5;

do
{
    System.Console.Write("請輸入猜測數字 :");
    num = System.Convert.ToInt32(Console.ReadLine());
    round++;
    if (round >= limit && num !=randomAns)
    {
        System.Console.WriteLine("次數用盡，你輸了");
        System.Console.WriteLine($"答案為{randomAns}");
    }
    else
    {
        if (num < randomAns)
        {
            System.Console.WriteLine($"比{num}大");
            System.Console.WriteLine($"還有{limit - round}次機會");
        }
        else if (num > randomAns)
        {
            System.Console.WriteLine($"比{num}小");
            System.Console.WriteLine($"還有{limit - round}次機會");
        }
        else
        {
            {
                System.Console.WriteLine("恭喜答對了!");
            }
        }
    }
}
while (num != randomAns && round != limit);
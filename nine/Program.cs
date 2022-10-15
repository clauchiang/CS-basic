for(int i = 1; i<=9; i++){
    for (int j = 1; j <=9; j++)
    {
        if((i*j) < 10){
            Console.Write($"{i} x {j} = 0{i*j} ");
        }else{
            Console.Write($"{i} x {j} = {i*j} ");
        }
    }
    Console.WriteLine();
    Console.Write("\n");
}
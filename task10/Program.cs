Console.Clear();
Console.Write ("Введите трехзначное число :");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n%100;
int n2 = n%10;
int n3  = ((n1 - n2)/10);
Console.Write(n3);


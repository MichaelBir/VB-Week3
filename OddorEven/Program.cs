line2:

//palub kasutajal siestada nubmer
Console.WriteLine("Sisesta on number");

int userNum = Convert.ToInt32(Console.ReadLine());

//kas arv on paaris või paaritu

int result = userNum % 2;

Console.WriteLine(result);

//väljastab vastuse number on paaritu

if(result != 0) //!=0 ei ole
    {
    Console.WriteLine("Sisestatud number on paaritu");
    }

//väljastab vastuse nubmer on paaris
else
    {
    Console.WriteLine("Sisestatud number on paaris");
    }
//algusesse tagasi
goto line2;
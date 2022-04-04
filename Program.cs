double peso, altura, IMC;
string diagnostico; 

Console.WriteLine("Calculadora de IMC\n");

Console.Write("Digite seu peso em kg: ");
peso = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Digite sua altura: ");
altura = Convert.ToDouble(Console.ReadLine()); 

IMC = peso /Math.Pow(altura , 2);

Console.WriteLine($"\nseu imc é {IMC:n2}"); 

if(IMC < 17)
{   
    diagnostico = "Muito abaixo do peso";
}

else if(IMC < 18.5)
{   
    diagnostico = "Abaixo do peso";
}

else if(IMC < 25)
{   
    diagnostico = "Peso normal";
}

else if(IMC < 30)
{   
    diagnostico = "Acima do peso";
}

else if(IMC < 35)
{   
    diagnostico = "Obesidade I";
}

else if(IMC < 40)
{   
    diagnostico = "Obesidade II";
}

else
{   
    diagnostico = "Obesidade III";
}

Console.WriteLine($"seu Diagnóstico: {diagnostico}");

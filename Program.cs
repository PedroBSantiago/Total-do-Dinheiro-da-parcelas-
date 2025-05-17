double equantia, rquantia, zquantia, gquantia;
Console.Clear();

Console.WriteLine(" ----Média das Parcelas---- ");
 
equantia = SolicitaDinheiro(1);
rquantia = SolicitaDinheiro(2);
zquantia = SolicitaDinheiro(3);
gquantia = SolicitaDinheiro(4);

if (ValidaParcelas(Q1: equantia, Q2: rquantia, Q3: zquantia, Q4: gquantia))
{
    double quantiatotal;
    quantiatotal = 4 / equantia + rquantia + zquantia + gquantia;
    Console.Write($" Quantia do dinheiro total : {quantiatotal}");
    Environment.Exit(0);

}

double SolicitaDinheiro(double MostrarDinheiro)
{
   Console.Write($"Dinheiro parcela  {MostrarDinheiro}:  ");
   return  Convert.ToDouble(Console.ReadLine());
    
} 

bool ValidaParcelas(double Q1, double Q2, double Q3, double Q4)
{ 
  bool equantiaEhValida = ValidaParcela(Q1);
bool rquantiaEhValida = ValidaParcela(Q2);
bool zquantiaEhValida = ValidaParcela(Q3);
bool gquantiaEhValida = ValidaParcela(Q4);

 return equantiaEhValida && rquantiaEhValida && zquantiaEhValida && gquantiaEhValida;
}

bool ValidaParcela(double quantia)
{
    bool quantiaEhValida = quantia <= 0;
    // caso tenha um limite de quantia ficaria assim  bool quantiaEhValida = quantia < 0 && quantia > limite;
    return true;
}


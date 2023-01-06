using System;
using System.Collections.Generic;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

        Console.WriteLine(Suite.TipoSuite);

        try
        {
            
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
        }
        catch(Exception)
        {
            Console.WriteLine("A capacidade da suíte não é suficiente para a quantidade de hóspedes");
        }
       
       
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        // TODO: Retorna o valor da diária
        // Cálculo: DiasReservados X Suite.ValorDiaria
        decimal valorDiaria = (DiasReservados * Suite.ValorDiaria);   

        // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
       
        if(DiasReservados >= 10)
        {
            decimal valor = 0;
            valor = valorDiaria / 10;

            decimal valorDesc = valorDiaria - valor;

            valorDiaria = valorDesc;
        }
       

        return valorDiaria;
    }
}


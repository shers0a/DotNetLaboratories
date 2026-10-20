using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers;

//exercitiul 1: 
public class HomeController : Controller
{
    //HttpGet nu e atat de deep - doar preia ruta si salveaza parametrii (get gen) si dupa pui metoda care reprezinta ce se intampla pe ruta respectiva
    //de observat ca toate metodele returneaza string -> deoarece pe site se afiseaza string uri (mesaje)
    
   [HttpGet("concatenare/{param1}/{param2}")]
    public string Concatenare(string param1, string param2)
    {
        return param1 + param2;
    }

    [HttpGet("produs/{param1: int}/{param2: int}")]
    public string Produs(int? param1, int? param2)
    {
        if(param1 == null)
        {
            return "Introduceti prima valoare.";
        }

        if(param2 == null)
        {
            return "Introduceti ambele valori.";
        }

        return $"{param1} * {param2} = {param1 * param2}";
    }

    [HttpGet("operatie/{param1: int}/{param2: int}/{param3}")]
    public string Operatie(int? param1, int? param2, string? param3)
    {
        if(param1 == null)
        {
            return "Introduceti prima valoare";
        }

        if(param2 == null)
        {
            return "Introduceti ambele valori.";
        }

        if(param3 == null)
        {
            return "Introduceti tipul de operatie din urmatoarele: +, -, *, /.";
        }

        switch (param3)
        {
            case "+":
                return $"{param1} + {param2} = {param1 + param2}";

            case "-":
                return $"{param1} - {param2} = {param1 - param2}";

            case "*":
                return $"{param1} * {param2} = {param1 * param2}";

            case "/":
                return $"{param1} / {param2} = {param1 / param2}";

            default:
                return "Operatie invalida.";
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers;

public class SearchController : Controller
{
    public string NumarTelefon(string? nr)
    {
        if(nr == null)
        {
            return "Introduceti numarul de telefon.";
        }

        if(nr < 10)
        {
            return "Numarul are prea putine cifre.";
        }

        if(nr > 10)
        {
            return "Numarul are prea multe cifre.";
        }

        return $"Cautare numar de telefon: {nr}";
    }
}
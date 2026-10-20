using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controller;

public class StudentController : Controller
{
    public string Index()
    {
        return "Toti studentii: ";
    }

    [HttpGet]
    public string Show(int? id)
    {
        if(id == null)
            return "Introduceti un id.";

        return $"Studentul cu id-ul: {id}";
    }

    [HttpPost]
    public string Create()
    {
        return "Creeaza student in baza de date.";
    }

    [HttpPut]
    public string Edit(int? id)
    {
        return $"Editare student cu id-ul: {id}";
    }

    [HttpDelete]
    public string Delete(int? id)
    {
        return $"Stergere student cu id-ul: {id}";
    }
}   
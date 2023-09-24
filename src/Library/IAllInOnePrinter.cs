//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IAllInOnePrinter
    {
        public void PrintRecipe(Recipe recipe);
    }
}

/* Para realizar estos cambios utilicé el patrón del polimorfismo. */
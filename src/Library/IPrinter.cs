//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;


namespace Full_GRASP_And_SOLID.Library
{
   
    public interface IPrinter
    {
        public void PrintRecipe();  /*Esta operacion es polimorica.*/
    }

    /*Para evitar que se pregunte el destino de la impresion, creé una tipo IPrinter
    que tiene la operacion PrintRecipe() que cada clase que la implemente la usa y le agrega funcionalidades
    que quiera. Esta interfaz cumple por el patrón Polimorfismo, ya que puede ser implementada por distintas clases.*/
}
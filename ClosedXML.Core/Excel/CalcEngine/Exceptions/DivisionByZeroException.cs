﻿using System;

namespace ClosedXML.Excel.CalcEngine.Exceptions
{
    /// <summary>
    /// The division operation in your formula refers to a cell that
    /// contains the value 0 or is blank.
    /// Corresponds to the #DIV/0! error in Excel
    /// </summary>
    /// <seealso cref="System.DivideByZeroException" />
    internal class DivisionByZeroException : CalcEngineException
    {
        public DivisionByZeroException()
            : base()
        { }

        public DivisionByZeroException(string message)
            : base(message)
        { }

        public DivisionByZeroException(string message, Exception innerException)
            : base(message, innerException)
        { }

    }
}
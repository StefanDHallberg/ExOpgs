using System;

namespace TotallySafeLib
{
    public class NegativeIndexOutOfRangeException : Exception
    {
        public NegativeIndexOutOfRangeException() : base()
        {
        }

        public NegativeIndexOutOfRangeException(string message)
            : base(message)
        {
        }

        public NegativeIndexOutOfRangeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}

/*
•	Definér din egen brugerdefinerede exception-klasse NegativeIndexOutOfRangeException, dvs. opret en ny klasse til dette formål i dit TotallySafe-bibliotek.
    Sørg for, at din nye exception-klasse implementerer de tre constructors nævnt i forberedelsen How to create user-defined exceptions.
•	Opdatér koden i GetValueAtPosition-metoden, så den kaster din nye exception med en passende exception-tekst, hvis indekset angivet i positionInArray-parameteren er negativt.
•	Opdatér koden i Main-metoden, så den også fanger din nye exception (samtidig med den automatisk genererede).
•	Afprøv med et kald til GetValueAtPosition-metoden med et negativt argument og se, om din nye exception faktisk virker. */

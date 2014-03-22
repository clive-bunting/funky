namespace Funky.Tests
open NUnit.Framework
open Funky.GregorianDateFunctions
open System

module GregorianDateFunctionTests =

    [<TestFixture>]
    type TestGregorianDateFunctions() =

        [<Test>]
        member x.Supplied_Date_Is_Win2012_Contract() =
            Assert.AreEqual("Win-2012", SeasonlyContractName (new DateTime (2013, 1, 1)))        


namespace Funky
open System

module GregorianDateFunctions=

    let (|Winter|Summer|) input = 
        if input >= 4 && input <= 9 then Summer
        else Winter

    let Day (x : DateTime) = 
        x.Day

    let Week (x : DateTime) =
        x.DayOfWeek

    let Month (x : DateTime) =
        x.Month

    let Quarter (x : DateTime) : int =
        let month = Month x
        (month - 1) / 3 + 1

    let Season (x : DateTime) : string = 
        match (Month x) with
            | Winter -> "Win"
            | Summer -> "Sum"             

    let Year (x : DateTime) =
        x.Year


   // let DailyContractName

   // let WeeklyContractName

    let QuarterlyContractName (x : DateTime) : string =
        Quarter x |> sprintf "Q%i"

    let SeasonlyContractName (x : DateTime) : string =
        let year = Year x
        let quarter = Quarter x
        match quarter with
            | 1 -> sprintf "%s-%i" (Season x) (year-1)
            | _ -> sprintf "%s-%i" (Season x) year


    // let YearlyContractName

    let FirstDayOfYear (x : int) : DateTime =
        new DateTime( year = x, month = 1, day = 1 )
        
    let LastDayOfYear (x : int) =
        new DateTime( year = x, month = 12, day = 31 )

    let FirstHourOfTheDay () =
        new TimeSpan (hours = 0, minutes = 0, seconds = 0)

    // let FirstDayOfWeek
    // let FirstDayOfMonth
    // let FirstDayOfQuarter
    // let FirstDayOfSeason


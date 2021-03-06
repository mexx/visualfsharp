module ``FSharp-Tests-Typecheck``

open System
open System.IO
open NUnit.Framework

open FSharpTestSuiteTypes
open NUnitConf
open PlatformHelpers

let testContext = FSharpTestSuite.testContext


module ``Full-rank-arrays`` = 

    [<Test; FSharpSuitePermutations("typecheck/full-rank-arrays")>]
    let ``full-rank-arrays`` p = check (processor {
        let { Directory = dir; Config = cfg } = testContext ()

        let exec p = Command.exec dir cfg.EnvironmentVariables { Output = Inherit; Input = None; } p >> checkResult
        let csc = Printf.ksprintf (Commands.csc exec cfg.CSC)
        
        // %CSC% /target:library /out:HighRankArrayTests.dll .\Class1.cs
        do! csc "/target:library /out:HighRankArrayTests.dll" ["Class1.cs"]

        do! SingleTestBuild.singleTestBuild cfg dir p
        
        do! SingleTestRun.singleTestRun cfg dir p
        })


module Misc = 

    [<Test; FSharpSuitePermutations("typecheck/misc")>]
    let misc p = check (processor {
        let { Directory = dir; Config = cfg } = testContext ()
        
        do! SingleTestBuild.singleTestBuild cfg dir p
        
        do! SingleTestRun.singleTestRun cfg dir p
        })


module Sigs = 

    [<Test; FSharpSuiteTest("typecheck/sigs")>]
    let sigs () = check (processor {
        let { Directory = dir; Config = cfg } = testContext ()

        let exec p = Command.exec dir cfg.EnvironmentVariables { Output = Inherit; Input = None; } p >> checkResult
        let fsc = Printf.ksprintf (Commands.fsc exec cfg.FSC)
        let peverify = Commands.peverify exec cfg.PEVERIFY
        let fsc_flags = cfg.fsc_flags

        let singleNegTest = SingleNegTest.singleNegTest cfg dir


        // call ..\..\single-neg-test.bat neg91
        do! singleNegTest "neg91"

        // "%FSC%" %fsc_flags% --target:exe -o:pos20.exe  pos20.fs 
        do! fsc "%s --target:exe -o:pos20.exe" fsc_flags ["pos20.fs"]
        // "%PEVERIFY%" pos20.exe
        do! peverify "pos20.exe"
        // pos20.exe
        do! exec ("."/"pos20.exe") ""

        // "%FSC%" %fsc_flags% --target:exe -o:pos19.exe  pos19.fs 
        do! fsc "%s --target:exe -o:pos19.exe" fsc_flags ["pos19.fs"]
        // "%PEVERIFY%" pos19.exe
        do! peverify "pos19.exe"
        // pos19.exe
        do! exec ("."/"pos19.exe") ""

        // "%FSC%" %fsc_flags% --target:exe -o:pos18.exe  pos18.fs 
        do! fsc "%s --target:exe -o:pos18.exe" fsc_flags ["pos18.fs"]
        // "%PEVERIFY%" pos18.exe
        do! peverify "pos18.exe"
        // pos18.exe
        do! exec ("."/"pos18.exe") ""

        // "%FSC%" %fsc_flags% --target:exe -o:pos16.exe  pos16.fs 
        do! fsc "%s --target:exe -o:pos16.exe" fsc_flags ["pos16.fs"]
        // "%PEVERIFY%" pos16.exe
        do! peverify "pos16.exe"
        // pos16.exe
        do! exec ("."/"pos16.exe") ""

        // "%FSC%" %fsc_flags% --target:exe -o:pos17.exe  pos17.fs 
        do! fsc "%s --target:exe -o:pos17.exe" fsc_flags ["pos17.fs"]
        // "%PEVERIFY%" pos17.exe
        do! peverify "pos17.exe"
        // pos17.exe
        do! exec ("."/"pos17.exe") ""

        // "%FSC%" %fsc_flags% --target:exe -o:pos15.exe  pos15.fs 
        do! fsc "%s --target:exe -o:pos15.exe" fsc_flags ["pos15.fs"]
        // "%PEVERIFY%" pos15.exe
        do! peverify "pos15.exe"
        // pos15.exe
        do! exec ("."/"pos15.exe") ""

        // "%FSC%" %fsc_flags% --target:exe -o:pos14.exe  pos14.fs 
        do! fsc "%s --target:exe -o:pos14.exe" fsc_flags ["pos14.fs"]
        // "%PEVERIFY%" pos14.exe
        do! peverify "pos14.exe"
        // pos14.exe
        do! exec ("."/"pos14.exe") ""

        // "%FSC%" %fsc_flags% --target:exe -o:pos13.exe  pos13.fs
        do! fsc "%s --target:exe -o:pos13.exe" fsc_flags ["pos13.fs"]
        // "%PEVERIFY%" pos13.exe
        do! peverify "pos13.exe"
        // pos13.exe
        do! exec ("."/"pos13.exe") ""

        // "%FSC%" %fsc_flags% -a -o:pos12.dll  pos12.fs 
        do! fsc "%s -a -o:pos12.dll" fsc_flags ["pos12.fs"]

        // "%FSC%" %fsc_flags% -a -o:pos11.dll  pos11.fs 
        do! fsc "%s -a -o:pos11.dll" fsc_flags ["pos11.fs"]

        // "%FSC%" %fsc_flags% -a -o:pos10.dll  pos10.fs
        do! fsc "%s -a -o:pos10.dll" fsc_flags ["pos10.fs"]

        // "%PEVERIFY%" pos10.dll
        do! peverify "pos10.dll"

        // call ..\..\single-neg-test.bat neg90
        // call ..\..\single-neg-test.bat neg89
        // call ..\..\single-neg-test.bat neg88
        do! processor.For (["neg90"; "neg89"; "neg88"], singleNegTest)

        // "%FSC%" %fsc_flags% -a -o:pos09.dll  pos09.fs
        do! fsc "%s -a -o:pos09.dll" fsc_flags ["pos09.fs"]

        // "%PEVERIFY%" pos09.dll
        do! peverify "pos09.dll"

        // call ..\..\single-neg-test.bat neg87
        // call ..\..\single-neg-test.bat neg86
        // call ..\..\single-neg-test.bat neg85
        // call ..\..\single-neg-test.bat neg84
        // call ..\..\single-neg-test.bat neg83
        // call ..\..\single-neg-test.bat neg82
        // call ..\..\single-neg-test.bat neg81
        // call ..\..\single-neg-test.bat neg80
        // call ..\..\single-neg-test.bat neg79
        // call ..\..\single-neg-test.bat neg78
        // call ..\..\single-neg-test.bat neg77
        // call ..\..\single-neg-test.bat neg76
        // call ..\..\single-neg-test.bat neg75
        // call ..\..\single-neg-test.bat neg74
        // call ..\..\single-neg-test.bat neg73
        // call ..\..\single-neg-test.bat neg72
        // call ..\..\single-neg-test.bat neg71
        // call ..\..\single-neg-test.bat neg70
        // call ..\..\single-neg-test.bat neg69
        // call ..\..\single-neg-test.bat neg68
        // call ..\..\single-neg-test.bat neg67
        // call ..\..\single-neg-test.bat neg66
        // call ..\..\single-neg-test.bat neg65
        // call ..\..\single-neg-test.bat neg64
        // call ..\..\single-neg-test.bat neg61
        // call ..\..\single-neg-test.bat neg63
        // call ..\..\single-neg-test.bat neg62
        // call ..\..\single-neg-test.bat neg20
        // call ..\..\single-neg-test.bat neg24
        // call ..\..\single-neg-test.bat neg32
        // call ..\..\single-neg-test.bat neg37
        // call ..\..\single-neg-test.bat neg37_a
        // call ..\..\single-neg-test.bat neg60
        // call ..\..\single-neg-test.bat neg59
        // call ..\..\single-neg-test.bat neg58
        // call ..\..\single-neg-test.bat neg57
        // call ..\..\single-neg-test.bat neg56
        // call ..\..\single-neg-test.bat neg56_a
        // call ..\..\single-neg-test.bat neg56_b
        // call ..\..\single-neg-test.bat neg55
        // call ..\..\single-neg-test.bat neg54
        // call ..\..\single-neg-test.bat neg53
        // call ..\..\single-neg-test.bat neg52
        // call ..\..\single-neg-test.bat neg51
        // call ..\..\single-neg-test.bat neg50
        // call ..\..\single-neg-test.bat neg49
        // call ..\..\single-neg-test.bat neg48
        // call ..\..\single-neg-test.bat neg47
        // call ..\..\single-neg-test.bat neg46
        // call ..\..\single-neg-test.bat neg10
        // call ..\..\single-neg-test.bat neg10_a
        // call ..\..\single-neg-test.bat neg45
        // call ..\..\single-neg-test.bat neg44
        // call ..\..\single-neg-test.bat neg43
        // call ..\..\single-neg-test.bat neg38
        // call ..\..\single-neg-test.bat neg39
        // call ..\..\single-neg-test.bat neg40
        // call ..\..\single-neg-test.bat neg41
        // call ..\..\single-neg-test.bat neg42
        do! processor.For (["neg87"; "neg86"; "neg85"; "neg84"; "neg83"; "neg82"; "neg81"; "neg80"; "neg79"; "neg78"; "neg77"; "neg76"; "neg75"; "neg74"; "neg73"; "neg72"; "neg71"; "neg70"; "neg69"; "neg68"; "neg67"; "neg66"; "neg65"; "neg64"; "neg61"; "neg63"; "neg62"; "neg20"; "neg24"; "neg32"; "neg37"; "neg37_a"; "neg60"; "neg59"; "neg58"; "neg57"; "neg56"; "neg56_a"; "neg56_b"; "neg55"; "neg54"; "neg53"; "neg52"; "neg51"; "neg50"; "neg49"; "neg48"; "neg47"; "neg46"; "neg10"; "neg10_a"; "neg45"; "neg44"; "neg43"; "neg38"; "neg39"; "neg40"; "neg41"; "neg42"], singleNegTest)

        // "%FSC%" %fsc_flags% -a -o:pos07.dll  pos07.fs 
        do! fsc "%s -a -o:pos07.dll" fsc_flags ["pos07.fs"]

        // "%PEVERIFY%" pos07.dll
        do! peverify "pos07.dll"


        // "%FSC%" %fsc_flags% -a -o:pos08.dll  pos08.fs 
        do! fsc "%s -a -o:pos08.dll" fsc_flags ["pos08.fs"]

        // "%PEVERIFY%" pos08.dll
        do! peverify "pos08.dll"

        // "%FSC%" %fsc_flags% -a -o:pos06.dll  pos06.fs 
        do! fsc "%s -a -o:pos06.dll" fsc_flags ["pos06.fs"]

        // "%PEVERIFY%" pos06.dll
        do! peverify "pos06.dll"


        // "%FSC%" %fsc_flags% -a -o:pos03.dll  pos03.fs 
        do! fsc "%s -a -o:pos03.dll" fsc_flags ["pos03.fs"]

        // "%PEVERIFY%" pos03.dll
        do! peverify "pos03.dll"

        // "%FSC%" %fsc_flags% -a -o:pos03a.dll  pos03a.fsi pos03a.fs 
        do! fsc "%s -a -o:pos03a.dll" fsc_flags ["pos03a.fsi"; "pos03a.fs"]

        // "%PEVERIFY%" pos03a.dll
        do! peverify "pos03a.dll"


        // call ..\..\single-neg-test.bat neg34
        // call ..\..\single-neg-test.bat neg33
        // call ..\..\single-neg-test.bat neg30
        // call ..\..\single-neg-test.bat neg31
        // call ..\..\single-neg-test.bat neg29
        // call ..\..\single-neg-test.bat neg28
        // call ..\..\single-neg-test.bat neg07
        // call ..\..\single-neg-test.bat neg_byref_20
        // call ..\..\single-neg-test.bat neg_byref_1
        // call ..\..\single-neg-test.bat neg_byref_2
        // call ..\..\single-neg-test.bat neg_byref_3
        // call ..\..\single-neg-test.bat neg_byref_4
        // call ..\..\single-neg-test.bat neg_byref_5
        // call ..\..\single-neg-test.bat neg_byref_6
        // call ..\..\single-neg-test.bat neg_byref_7
        // call ..\..\single-neg-test.bat neg_byref_8
        // call ..\..\single-neg-test.bat neg_byref_10
        // call ..\..\single-neg-test.bat neg_byref_11
        // call ..\..\single-neg-test.bat neg_byref_12
        // call ..\..\single-neg-test.bat neg_byref_13
        // call ..\..\single-neg-test.bat neg_byref_14
        // call ..\..\single-neg-test.bat neg_byref_15
        // call ..\..\single-neg-test.bat neg_byref_16
        // call ..\..\single-neg-test.bat neg_byref_17
        // call ..\..\single-neg-test.bat neg_byref_18
        // call ..\..\single-neg-test.bat neg_byref_19
        // call ..\..\single-neg-test.bat neg_byref_21
        // call ..\..\single-neg-test.bat neg_byref_22
        // call ..\..\single-neg-test.bat neg_byref_23
        // call ..\..\single-neg-test.bat neg36
        // call ..\..\single-neg-test.bat neg17
        // call ..\..\single-neg-test.bat neg26
        // call ..\..\single-neg-test.bat neg27
        // call ..\..\single-neg-test.bat neg25
        // call ..\..\single-neg-test.bat neg03
        // call ..\..\single-neg-test.bat neg23
        // call ..\..\single-neg-test.bat neg22
        // call ..\..\single-neg-test.bat neg21
        // call ..\..\single-neg-test.bat neg04
        // call ..\..\single-neg-test.bat neg05
        // call ..\..\single-neg-test.bat neg06
        // call ..\..\single-neg-test.bat neg06_a
        // call ..\..\single-neg-test.bat neg06_b
        // call ..\..\single-neg-test.bat neg08
        // call ..\..\single-neg-test.bat neg09
        // call ..\..\single-neg-test.bat neg11
        // call ..\..\single-neg-test.bat neg12
        // call ..\..\single-neg-test.bat neg13
        // call ..\..\single-neg-test.bat neg14
        // call ..\..\single-neg-test.bat neg16
        // call ..\..\single-neg-test.bat neg18
        // call ..\..\single-neg-test.bat neg19
        // call ..\..\single-neg-test.bat neg01
        // call ..\..\single-neg-test.bat neg02
        // call ..\..\single-neg-test.bat neg15

        do! processor.For(["neg34"; "neg33"; "neg30"; "neg31"; "neg29"; "neg28"; "neg07"; "neg_byref_20"; "neg_byref_1"; "neg_byref_2"; "neg_byref_3"; "neg_byref_4"; "neg_byref_5"; "neg_byref_6"; "neg_byref_7"; "neg_byref_8"; "neg_byref_10"; "neg_byref_11"; "neg_byref_12"; "neg_byref_13"; "neg_byref_14"; "neg_byref_15"; "neg_byref_16"; "neg_byref_17"; "neg_byref_18"; "neg_byref_19"; "neg_byref_21"; "neg_byref_22"; "neg_byref_23"; "neg36"; "neg17"; "neg26"; "neg27"; "neg25"; "neg03"; "neg23"; "neg22"; "neg21"; "neg04"; "neg05"; "neg06"; "neg06_a"; "neg06_b"; "neg08"; "neg09"; "neg11"; "neg12"; "neg13"; "neg14"; "neg16"; "neg18"; "neg19"; "neg01"; "neg02"; "neg15" ], singleNegTest)

        // echo Some random positive cases found while developing the negative tests
        // "%FSC%" %fsc_flags% -a -o:pos01a.dll  pos01a.fsi pos01a.fs
        do! fsc "%s -a -o:pos01a.dll" fsc_flags ["pos01a.fsi"; "pos01a.fs"]

        // "%PEVERIFY%" pos01a.dll
        do! peverify "pos01a.dll"

        // "%FSC%" %fsc_flags% -a -o:pos02.dll  pos02.fs
        do! fsc "%s -a -o:pos02.dll" fsc_flags ["pos02.fs"]

        // "%PEVERIFY%" pos02.dll
        do! peverify "pos02.dll"

        // call ..\..\single-neg-test.bat neg35
        do! singleNegTest "neg35"

        // "%FSC%" %fsc_flags% -a -o:pos05.dll  pos05.fs
        do! fsc "%s -a -o:pos05.dll" fsc_flags ["pos05.fs"]

        })

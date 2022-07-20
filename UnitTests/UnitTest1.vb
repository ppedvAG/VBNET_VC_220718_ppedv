Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Fahrzeugpark

'UNIT-TESTS sind simple Überprüfungen, mit denen kleine Programmteile über längere Zeit auf ihre korrekte
''Funktionalität hin überprüft werden können. Ausgeführt werden diese über das 'Test'-Menü
<TestClass()>
Public Class UnitTest_PKW

    <TestMethod()>
    Public Sub Beschleunige_PKW_ueber_MaxG()

        Dim pkw1 As PKW = New PKW("BMW", 230, 25000, 5)

        pkw1.StarteMotor()
        pkw1.Beschleunige(pkw1.MaxGeschwindigkeit + 1)

        'Jede TestMethod muss mindestens einen Zugriff auf die Assert-Klasse nehmen, mit deren Methoden die
        ''zu überprüfenden Programmteile getestet werden. Ein Test gilt als erfolgreich, wenn alle Assert-Methoden
        ''in einer TestMethod ein true zurückgeben.
        Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit)

    End Sub

    <TestMethod()>
    Public Sub Bremse_PKW_unter_0()

        Dim pkw1 As PKW = New PKW("BMW", 230, 25000, 5)

        pkw1.StarteMotor()
        pkw1.Beschleunige(200)
        pkw1.Beschleunige(-201)

        Assert.AreEqual(0, pkw1.AktGeschwindigkeit)

    End Sub

End Class
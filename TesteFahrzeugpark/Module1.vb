Imports Fahrzeugpark

Module Module1

    Sub Main()

        Dim fz1 As Fahrzeugpark.Fahrzeug = New Fahrzeug("BMW", 230)
        Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 340)

        Console.WriteLine(fz1.Name)

        fz1.Name = "Audi"
        Console.WriteLine(fz1.Name)

        fz1.Name = ""
        Console.WriteLine(fz1.Name)

        Console.WriteLine(fz1.BeschreibeMich())
        Console.WriteLine(fz2.BeschreibeMich())

        Console.WriteLine(fz1.MaxGeschwindigkeit)
        'fz1.MaxGeschwindigkeit = 123

        Console.ReadKey()
    End Sub

End Module

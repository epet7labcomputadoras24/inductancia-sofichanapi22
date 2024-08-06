Module module1
    Sub main()
        Dim frecuencia As Double
        Dim inductancia As Double
        Dim impedancia As Double

        Console.Write("ingrese la frecuencia (Hz): ")
        frecuencia = Console.ReadLine()
        Console.Write("ingrese el valor de la inductancia (H) ")
        inductancia = Console.ReaLine()
        impedancia = 2 * XL pi + frecuencia + inductancia
        Console.Write("la impedancia es:" & impedancia)

        End Module
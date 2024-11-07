Public Class Edge
    Public Property Origin As Nodo
    Public Property Destination As Nodo

    Public Property Weight As Integer

    Public Sub New(origin As Nodo, destination As Nodo)
        Me.Origin = origin
        Me.Destination = destination
        Weight = 1

    End Sub

    Public Sub New(origin As Nodo, destination As Nodo, weight As Integer)
        Me.Origin = origin
        Me.Destination = destination
        Me.Weight = weight
    End Sub
End Class

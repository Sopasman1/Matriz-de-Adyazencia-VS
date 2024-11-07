Public Class Graph
    Public Property Nodes As List(Of Nodo)
    Public Property Edges As List(Of Edge)

    Public Property Matrix As Integer(,)


    Public Sub New()
        Nodes = New List(Of Nodo)()
        Edges = New List(Of Edge)()
        Matrix = New Integer(-1, -1) {}

    End Sub

    Public Sub AddNode(name As String)
        Dim newNode As Nodo = New Nodo(name)
        Nodes.Add(newNode)

        ' Expandir la matriz de adyacencia al agregar un nuevo nodo
        Dim newSize = Nodes.Count
        Dim newMatrix = New Integer(newSize - 1, newSize - 1) {}

        ' Copiar los valores de la matriz antigua a la nueva
        For i = 0 To newSize - 1 - 1
            For j = 0 To newSize - 1 - 1
                newMatrix(i, j) = Matrix(i, j)
            Next
        Next

        ' Asignar la nueva matriz a Matrix
        Matrix = newMatrix

    End Sub

    Public Sub AddEdge(origin As String, destination As String)
        AddEdge(origin, destination, 1) ' Por defecto, el peso es 1
    End Sub

    Public Sub AddEdge(origin As String, destination As String, weight As Integer)
        Dim nodoOrigin = Nodes.Find(Function(n) Equals(n.Name, origin))
        Dim nodoDestination = Nodes.Find(Function(n) Equals(n.Name, destination))

        If nodoOrigin IsNot Nothing AndAlso nodoDestination IsNot Nothing Then
            Edges.Add(New Edge(nodoOrigin, nodoDestination, weight))

            ' Actualizar la matriz de adyacencia
            Dim indexOrigin = Nodes.IndexOf(nodoOrigin)
            Dim indexDestination = Nodes.IndexOf(nodoDestination)

            Matrix(indexOrigin, indexDestination) = weight
            Matrix(indexDestination, indexOrigin) = weight  ' Si el grafo es no dirigido
        End If
    End Sub

    Public Sub AddEdge2(origin2 As String, destination2 As String)
        AddEdge2(origin2, destination2, 1) ' Por defecto, el peso es 1
    End Sub

    Public Sub AddEdge2(origin2 As String, destination2 As String, weight2 As Integer)
        Dim nodoOrigin2 = Nodes.Find(Function(n) Equals(n.Name, origin2))
        Dim nodoDestination2 = Nodes.Find(Function(n) Equals(n.Name, destination2))

        If nodoOrigin2 IsNot Nothing AndAlso nodoDestination2 IsNot Nothing Then
            Edges.Add(New Edge(nodoOrigin2, nodoDestination2, weight2))

            ' Actualizar solo la celda [origen, destino] en la matriz de adyacencia
            Dim indexOrigin2 = Nodes.IndexOf(nodoOrigin2)
            Dim indexDestination2 = Nodes.IndexOf(nodoDestination2)

            Matrix(indexOrigin2, indexDestination2) = weight2  ' Solo de origen a destino
        End If
    End Sub

    ' Método BFS (Recorrido en anchura)
    Public Function BFS(startNodeName As String) As List(Of String)
        ' Buscar el nodo inicial por su nombre
        Dim startNode = Nodes.Find(Function(n) Equals(n.Name, startNodeName))
        If startNode Is Nothing Then
            Return New List(Of String)()  ' Si el nodo no existe, retorna una lista vacía
        End If

        ' Crear una lista para almacenar los nodos visitados
        Dim visited As List(Of String) = New List(Of String)()

        ' Crear una cola para el recorrido BFS
        Dim queue As Queue(Of Nodo) = New Queue(Of Nodo)()

        ' Crear un array para marcar los nodos visitados
        Dim visitedArray = New Boolean(Nodes.Count - 1) {}

        ' Obtener el índice del nodo inicial
        Dim startIndex = Nodes.IndexOf(startNode)

        ' Marcar el nodo inicial como visitado y agregarlo a la cola
        visitedArray(startIndex) = True
        queue.Enqueue(startNode)

        While queue.Count > 0
            ' Obtener el nodo al frente de la cola
            Dim currentNode As Nodo = queue.Dequeue()

            ' Agregar el nodo actual a la lista de visitados
            visited.Add(currentNode.Name)

            ' Obtener el índice del nodo actual
            Dim currentIndex = Nodes.IndexOf(currentNode)

            ' Explorar todos los nodos adyacentes (vecinos)
            For i = 0 To Nodes.Count - 1
                ' Si hay una conexión y el nodo no ha sido visitado
                If Matrix(currentIndex, i) <> 0 AndAlso Not visitedArray(i) Then
                    visitedArray(i) = True  ' Marcar el nodo como visitado
                    queue.Enqueue(Nodes(i))  ' Encolar el nodo vecino
                End If
            Next
        End While

        Return visited  ' Retornar la lista de nodos visitados
    End Function

    ' Método DFS recursivo (Recorrido en profundidad)
    Public Function DFS(startNodeName As String) As List(Of String)
        ' Buscar el nodo inicial por su nombre
        Dim startNode = Nodes.Find(Function(n) Equals(n.Name, startNodeName))
        If startNode Is Nothing Then
            Return New List(Of String)()  ' Si el nodo no existe, retorna una lista vacía
        End If

        ' Crear una lista para almacenar los nodos visitados
        Dim visited As List(Of String) = New List(Of String)()

        ' Crear un array para marcar los nodos visitados
        Dim visitedArray = New Boolean(Nodes.Count - 1) {}

        ' Obtener el índice del nodo inicial
        Dim startIndex = Nodes.IndexOf(startNode)

        ' Llamada inicial a la función recursiva
        DFSRecursivo(startIndex, visited, visitedArray)

        Return visited
    End Function

    ' Método auxiliar recursivo para DFS
    Private Sub DFSRecursivo(nodeIndex As Integer, visited As List(Of String), visitedArray As Boolean())
        ' Marcar el nodo actual como visitado
        visitedArray(nodeIndex) = True

        ' Agregar el nodo visitado a la lista
        visited.Add(Nodes(nodeIndex).Name)

        ' Explorar todos los nodos adyacentes (vecinos)
        For i = 0 To Nodes.Count - 1
            ' Si hay una conexión y el nodo no ha sido visitado
            If Matrix(nodeIndex, i) <> 0 AndAlso Not visitedArray(i) Then
                DFSRecursivo(i, visited, visitedArray)  ' Llamada recursiva al vecino no visitado
            End If
        Next
    End Sub

    ' Método DFS Iterativo (Usando Pila)
    Public Function DFSIterativo(startNodeName As String) As List(Of String)
        Dim startNode = Nodes.Find(Function(n) Equals(n.Name, startNodeName))
        If startNode Is Nothing Then
            Return New List(Of String)()
        End If

        Dim visited As List(Of String) = New List(Of String)()
        Dim visitedArray = New Boolean(Nodes.Count - 1) {}

        Dim stack As Stack(Of Nodo) = New Stack(Of Nodo)()

        Dim startIndex = Nodes.IndexOf(startNode)
        visitedArray(startIndex) = True
        stack.Push(startNode)

        While stack.Count > 0
            Dim currentNode As Nodo = stack.Pop()
            Dim currentIndex = Nodes.IndexOf(currentNode)
            visited.Add(currentNode.Name)

            For i = 0 To Nodes.Count - 1
                If Matrix(currentIndex, i) <> 0 AndAlso Not visitedArray(i) Then
                    visitedArray(i) = True
                    stack.Push(Nodes(i))
                End If
            Next
        End While

        Return visited
    End Function

    ' Método para eliminar un nodo
    Public Sub RemoveNode(name As String)
        ' Buscar el nodo a eliminar
        Dim nodeToRemove = Nodes.Find(Function(n) Equals(n.Name, name))
        If nodeToRemove Is Nothing Then
            Console.WriteLine("Nodo no encontrado.")
            Return
        End If

        ' Obtener el índice del nodo a eliminar
        Dim nodeIndex = Nodes.IndexOf(nodeToRemove)

        ' Eliminar las aristas que están conectadas a este nodo
        Edges.RemoveAll(Function(edge) edge.Origin Is nodeToRemove OrElse edge.Destination Is nodeToRemove)

        ' Eliminar el nodo de la lista de nodos
        Nodes.RemoveAt(nodeIndex)

        ' Actualizar la matriz de adyacencia eliminando la fila y columna del nodo
        Dim newSize = Nodes.Count
        Dim newMatrix = New Integer(newSize - 1, newSize - 1) {}

        ' Copiar los valores de la matriz antigua a la nueva, omitiendo la fila y columna del nodo eliminado
        Dim i = 0, newI = 0

        While i < Matrix.GetLength(0)
            If i = nodeIndex Then Continue While  ' Saltar la fila del nodo eliminado

            Dim j = 0, newJ = 0

            While j < Matrix.GetLength(1)
                If j = nodeIndex Then Continue While  ' Saltar la columna del nodo eliminado

                newMatrix(newI, newJ) = Matrix(i, j)
                newJ += 1
                j += 1
            End While

            newI += 1
            i += 1
        End While

        ' Asignar la nueva matriz
        Matrix = newMatrix


    End Sub

    ' Método para eliminar una arista (edge)
    Public Sub RemoveEdge(origin As String, destination As String)
        ' Buscar los nodos de origen y destino
        Dim nodoOrigin = Nodes.Find(Function(n) Equals(n.Name, origin))
        Dim nodoDestination = Nodes.Find(Function(n) Equals(n.Name, destination))

        If nodoOrigin Is Nothing OrElse nodoDestination Is Nothing Then
            Console.WriteLine("Nodo de origen o destino no encontrado.")
            Return
        End If

        ' Buscar la arista a eliminar
        Dim edgeToRemove = Edges.Find(Function(e) e.Origin Is nodoOrigin AndAlso e.Destination Is nodoDestination)

        If edgeToRemove Is Nothing Then
            Console.WriteLine("Arista no encontrada.")
            Return
        End If

        ' Eliminar la arista de la lista de aristas
        Edges.Remove(edgeToRemove)

        ' Actualizar la matriz de adyacencia (poniendo un 0 para indicar que no hay conexión)
        Dim originIndex = Nodes.IndexOf(nodoOrigin)
        Dim destinationIndex = Nodes.IndexOf(nodoDestination)

        If Matrix IsNot Nothing AndAlso originIndex >= 0 AndAlso destinationIndex >= 0 Then
            Matrix(originIndex, destinationIndex) = 0

            ' Si es un grafo no dirigido, también eliminar la conexión inversa
            Matrix(destinationIndex, originIndex) = 0
        End If
    End Sub
End Class


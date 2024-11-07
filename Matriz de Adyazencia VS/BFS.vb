Public Class BFS
    Inherits Form
    Private graph As Graph
    Public Sub New()
        InitializeComponent()
        graph = New Graph()
    End Sub

    Private Sub AddNode3_Click(sender As Object, e As EventArgs)
        Dim namenode = txtAddNode3.Text
        graph.AddNode(namenode)
        txtAddNode3.Clear()
    End Sub

    Private Sub btnAddEdge3_Click(sender As Object, e As EventArgs)
        Dim nodeOrigin = textv1_3.Text
        Dim nodeDest = textv2_3.Text

        If Not String.IsNullOrEmpty(nodeOrigin) AndAlso Not String.IsNullOrEmpty(nodeDest) Then
            ' Agregar la arista sin peso (peso por defecto será 1)
            graph.AddEdge2(nodeOrigin, nodeDest)
        End If

        ' Limpiar los campos de texto
        textv1_3.Clear()
        textv2_3.Clear()

    End Sub

    Private Sub MostrarMatrizAdyacencia()
        ' Limpiar el DataGridView para empezar desde cero
        DTGmatrx3.Columns.Clear()
        DTGmatrx3.Rows.Clear()

        ' Agregar la primera columna vacía (encabezado de filas) para los nombres de los nodos
        DTGmatrx3.Columns.Add("", "") ' La primera columna está vacía para los nombres de las filas

        ' Agregar columnas correspondientes a cada nodo (usando el nombre del nodo)
        For Each nodo In graph.Nodes
            DTGmatrx3.Columns.Add(nodo.Name, nodo.Name)  ' Agregar cada nodo como encabezado de columna
        Next

        ' Agregar filas con los nombres de los nodos y los valores de la matriz de adyacencia
        For i = 0 To graph.Nodes.Count - 1
            ' Crear una nueva fila
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.CreateCells(DTGmatrx3)

            ' La primera celda de cada fila es el nombre del nodo
            row.Cells(0).Value = graph.Nodes(i).Name

            ' Las siguientes celdas son los valores de la matriz de adyacencia (conexiones entre nodos)
            For j = 0 To graph.Nodes.Count - 1
                ' Verificar si hay conexión entre los nodos i y j, y mostrar el peso o "0" si no hay conexión
                row.Cells(j + 1).Value = If(graph.Matrix(i, j) <> 0, graph.Matrix(i, j).ToString(), "0")
            Next

            ' Agregar la fila al DataGridView
            DTGmatrx3.Rows.Add(row)
        Next
    End Sub

    Private Sub seeMatrix3_Click(sender As Object, e As EventArgs)
        MostrarMatrizAdyacencia()
    End Sub

    Private Sub btnBFS_Click(sender As Object, e As EventArgs)
        Dim startNode = txtStartNode.Text  ' Nodo de inicio que se ingresa en el formulario

        Dim bfsResult = graph.BFS(startNode)

        If bfsResult.Count > 0 Then
            MessageBox.Show("Recorrido BFS: " & String.Join(", ", bfsResult))
        Else
            MessageBox.Show("El nodo no existe o no se pudo realizar el recorrido.")
        End If
    End Sub

    Private Sub DeleteNode3_Click(sender As Object, e As EventArgs)
        ' Obtener el nombre del nodo a eliminar
        Dim nodeName = txtdeletenode3.Text

        If String.IsNullOrEmpty(nodeName) Then
            MessageBox.Show("Por favor, ingrese el nombre del nodo a eliminar.")
            Return
        End If

        ' Eliminar el nodo del grafo
        graph.RemoveNode(nodeName)

        ' Actualizar el DataGridView para reflejar los cambios en la matriz de adyacencia
        MostrarMatrizAdyacencia()

        ' Limpiar el campo de texto
        txtdeletenode3.Clear()
    End Sub

    Private Sub deleteedge3_Click(sender As Object, e As EventArgs)
        ' Obtener el nodo de origen y destino
        Dim originNode = txtvd_3.Text
        Dim destinationNode = txtvd2_3.Text

        If String.IsNullOrEmpty(originNode) OrElse String.IsNullOrEmpty(destinationNode) Then
            MessageBox.Show("Por favor, ingrese los nombres de los nodos de origen y destino.")
            Return
        End If

        ' Eliminar la arista del grafo
        graph.RemoveEdge(originNode, destinationNode)

        ' Actualizar el DataGridView para reflejar los cambios en la matriz de adyacencia
        MostrarMatrizAdyacencia()

        ' Limpiar los campos de texto
        txtvd_3.Clear()
        txtvd2_3.Clear()
    End Sub
End Class
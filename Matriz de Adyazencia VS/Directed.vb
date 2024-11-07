Public Class Directed
    Inherits Form
    Private graph As Graph
    Public Sub New()
        InitializeComponent()
        graph = New Graph()
    End Sub

    Private Sub AddNode2_Click(sender As Object, e As EventArgs)
        Dim namenode = txtAddNode2.Text
        graph.AddNode(namenode)
        txtAddNode2.Clear()


    End Sub

    Private Sub btnAddEdge2_Click(sender As Object, e As EventArgs)
        Dim nodeorigin = textv1_2.Text
        Dim nodedest = textv2_2.Text

        If String.IsNullOrEmpty(textweight2.Text) Then
            graph.AddEdge2(nodeorigin, nodedest)
        Else
            Dim weight = Integer.Parse(textweight2.Text)
            graph.AddEdge2(nodeorigin, nodedest, weight)
        End If

        textv1_2.Clear()
        textv2_2.Clear()
        textweight2.Clear()
    End Sub

    Private Sub MostrarMatrizAdyacencia()
        ' Limpiar el DataGridView para empezar desde cero
        DTGmatrx2.Columns.Clear()
        DTGmatrx2.Rows.Clear()

        ' Agregar la primera columna vacía (encabezado de filas) para los nombres de los nodos
        DTGmatrx2.Columns.Add("", "") ' La primera columna está vacía para los nombres de las filas

        ' Agregar columnas correspondientes a cada nodo (usando el nombre del nodo)
        For Each nodo In graph.Nodes
            DTGmatrx2.Columns.Add(nodo.Name, nodo.Name)  ' Agregar cada nodo como encabezado de columna
        Next

        ' Agregar filas con los nombres de los nodos y los valores de la matriz de adyacencia
        For i = 0 To graph.Nodes.Count - 1
            ' Crear una nueva fila
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.CreateCells(DTGmatrx2)

            ' La primera celda de cada fila es el nombre del nodo
            row.Cells(0).Value = graph.Nodes(i).Name

            ' Las siguientes celdas son los valores de la matriz de adyacencia (conexiones entre nodos)
            For j = 0 To graph.Nodes.Count - 1
                ' Verificar si hay conexión entre los nodos i y j, y mostrar el peso o "0" si no hay conexión
                row.Cells(j + 1).Value = If(graph.Matrix(i, j) <> 0, graph.Matrix(i, j).ToString(), "0")
            Next

            ' Agregar la fila al DataGridView
            DTGmatrx2.Rows.Add(row)
        Next
    End Sub

    Private Sub seeMatrix2_Click(sender As Object, e As EventArgs)
        MostrarMatrizAdyacencia()
    End Sub

    Private Sub DeleteNode2_Click(sender As Object, e As EventArgs)

        ' Obtener el nombre del nodo a eliminar
        Dim nodeName = txtdeletenode2.Text

        If String.IsNullOrEmpty(nodeName) Then
            MessageBox.Show("Por favor, ingrese el nombre del nodo a eliminar.")
            Return
        End If

        ' Eliminar el nodo del grafo
        graph.RemoveNode(nodeName)

        ' Actualizar el DataGridView para reflejar los cambios en la matriz de adyacencia
        MostrarMatrizAdyacencia()

        ' Limpiar el campo de texto
        txtdeletenode2.Clear()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs)
        ' Obtener el nodo de origen y destino
        Dim originNode = txtvd_2.Text
        Dim destinationNode = txtvd2_2.Text

        If String.IsNullOrEmpty(originNode) OrElse String.IsNullOrEmpty(destinationNode) Then
            MessageBox.Show("Por favor, ingrese los nombres de los nodos de origen y destino.")
            Return
        End If

        ' Eliminar la arista del grafo
        graph.RemoveEdge(originNode, destinationNode)

        ' Actualizar el DataGridView para reflejar los cambios en la matriz de adyacencia
        MostrarMatrizAdyacencia()

        ' Limpiar los campos de texto
        txtvd_2.Clear()
        txtvd2_2.Clear()
    End Sub
End Class
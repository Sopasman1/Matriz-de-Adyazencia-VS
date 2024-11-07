<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DFS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        label5 = New Label()
        btnDFS_I = New Button()
        txtStartNode2 = New TextBox()
        btnDFS = New Button()
        seeMatrix4 = New Button()
        DTGmatrx4 = New DataGridView()
        label4 = New Label()
        label3 = New Label()
        txtvd2_4 = New TextBox()
        txtvd_4 = New TextBox()
        deleteedge4 = New Button()
        txtdeletenode4 = New TextBox()
        DeleteNode4 = New Button()
        label2 = New Label()
        textv2_4 = New TextBox()
        textv1_4 = New TextBox()
        btnAddEdge4 = New Button()
        AddNode4 = New Button()
        txtAddNode4 = New TextBox()
        label1 = New Label()
        CType(DTGmatrx4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(7, 186)
        label5.Name = "label5"
        label5.Size = New Size(63, 15)
        label5.TabIndex = 96
        label5.Text = "Start Node"
        ' 
        ' btnDFS_I
        ' 
        btnDFS_I.Location = New Point(132, 212)
        btnDFS_I.Name = "btnDFS_I"
        btnDFS_I.Size = New Size(100, 23)
        btnDFS_I.TabIndex = 95
        btnDFS_I.Text = "DFS Interativo"
        btnDFS_I.UseVisualStyleBackColor = True
        ' 
        ' txtStartNode2
        ' 
        txtStartNode2.Location = New Point(76, 183)
        txtStartNode2.Name = "txtStartNode2"
        txtStartNode2.Size = New Size(100, 23)
        txtStartNode2.TabIndex = 94
        ' 
        ' btnDFS
        ' 
        btnDFS.Location = New Point(11, 212)
        btnDFS.Name = "btnDFS"
        btnDFS.Size = New Size(100, 23)
        btnDFS.TabIndex = 93
        btnDFS.Text = "DFS Recurcivo"
        btnDFS.UseVisualStyleBackColor = True
        ' 
        ' seeMatrix4
        ' 
        seeMatrix4.Location = New Point(18, 417)
        seeMatrix4.Name = "seeMatrix4"
        seeMatrix4.Size = New Size(134, 23)
        seeMatrix4.TabIndex = 92
        seeMatrix4.Text = "See Matrix"
        seeMatrix4.UseVisualStyleBackColor = True
        ' 
        ' DTGmatrx4
        ' 
        DTGmatrx4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DTGmatrx4.Location = New Point(314, 11)
        DTGmatrx4.Name = "DTGmatrx4"
        DTGmatrx4.Size = New Size(480, 429)
        DTGmatrx4.TabIndex = 91
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(248, 108)
        label4.Name = "label4"
        label4.Size = New Size(20, 15)
        label4.TabIndex = 90
        label4.Text = "V2"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(132, 108)
        label3.Name = "label3"
        label3.Size = New Size(20, 15)
        label3.TabIndex = 89
        label3.Text = "V1"
        ' 
        ' txtvd2_4
        ' 
        txtvd2_4.Location = New Point(132, 343)
        txtvd2_4.Name = "txtvd2_4"
        txtvd2_4.Size = New Size(100, 23)
        txtvd2_4.TabIndex = 88
        ' 
        ' txtvd_4
        ' 
        txtvd_4.Location = New Point(11, 343)
        txtvd_4.Name = "txtvd_4"
        txtvd_4.Size = New Size(100, 23)
        txtvd_4.TabIndex = 87
        ' 
        ' deleteedge4
        ' 
        deleteedge4.Location = New Point(11, 314)
        deleteedge4.Name = "deleteedge4"
        deleteedge4.Size = New Size(89, 23)
        deleteedge4.TabIndex = 86
        deleteedge4.Text = "Delete Edge"
        deleteedge4.UseVisualStyleBackColor = True
        ' 
        ' txtdeletenode4
        ' 
        txtdeletenode4.Location = New Point(11, 285)
        txtdeletenode4.Name = "txtdeletenode4"
        txtdeletenode4.Size = New Size(100, 23)
        txtdeletenode4.TabIndex = 85
        ' 
        ' DeleteNode4
        ' 
        DeleteNode4.Location = New Point(14, 256)
        DeleteNode4.Name = "DeleteNode4"
        DeleteNode4.Size = New Size(89, 23)
        DeleteNode4.TabIndex = 84
        DeleteNode4.Text = "Delete Node"
        DeleteNode4.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(18, 98)
        label2.Name = "label2"
        label2.Size = New Size(33, 15)
        label2.TabIndex = 83
        label2.Text = "Edge"
        ' 
        ' textv2_4
        ' 
        textv2_4.Location = New Point(208, 126)
        textv2_4.Name = "textv2_4"
        textv2_4.Size = New Size(100, 23)
        textv2_4.TabIndex = 82
        ' 
        ' textv1_4
        ' 
        textv1_4.Location = New Point(102, 126)
        textv1_4.Name = "textv1_4"
        textv1_4.Size = New Size(100, 23)
        textv1_4.TabIndex = 81
        ' 
        ' btnAddEdge4
        ' 
        btnAddEdge4.Location = New Point(11, 126)
        btnAddEdge4.Name = "btnAddEdge4"
        btnAddEdge4.Size = New Size(75, 23)
        btnAddEdge4.TabIndex = 80
        btnAddEdge4.Text = "Add Edge"
        btnAddEdge4.UseVisualStyleBackColor = True
        ' 
        ' AddNode4
        ' 
        AddNode4.Location = New Point(11, 45)
        AddNode4.Name = "AddNode4"
        AddNode4.Size = New Size(75, 23)
        AddNode4.TabIndex = 79
        AddNode4.Text = "Add Node"
        AddNode4.UseVisualStyleBackColor = True
        ' 
        ' txtAddNode4
        ' 
        txtAddNode4.Location = New Point(102, 45)
        txtAddNode4.Name = "txtAddNode4"
        txtAddNode4.Size = New Size(100, 23)
        txtAddNode4.TabIndex = 78
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(18, 11)
        label1.Name = "label1"
        label1.Size = New Size(36, 15)
        label1.TabIndex = 77
        label1.Text = "Node"
        ' 
        ' DFS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(label5)
        Controls.Add(btnDFS_I)
        Controls.Add(txtStartNode2)
        Controls.Add(btnDFS)
        Controls.Add(seeMatrix4)
        Controls.Add(DTGmatrx4)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(txtvd2_4)
        Controls.Add(txtvd_4)
        Controls.Add(deleteedge4)
        Controls.Add(txtdeletenode4)
        Controls.Add(DeleteNode4)
        Controls.Add(label2)
        Controls.Add(textv2_4)
        Controls.Add(textv1_4)
        Controls.Add(btnAddEdge4)
        Controls.Add(AddNode4)
        Controls.Add(txtAddNode4)
        Controls.Add(label1)
        Name = "DFS"
        Text = "DFS"
        CType(DTGmatrx4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label5 As Label
    Private WithEvents btnDFS_I As Button
    Private WithEvents txtStartNode2 As TextBox
    Private WithEvents btnDFS As Button
    Private WithEvents seeMatrix4 As Button
    Private WithEvents DTGmatrx4 As DataGridView
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtvd2_4 As TextBox
    Private WithEvents txtvd_4 As TextBox
    Private WithEvents deleteedge4 As Button
    Private WithEvents txtdeletenode4 As TextBox
    Private WithEvents DeleteNode4 As Button
    Private WithEvents label2 As Label
    Private WithEvents textv2_4 As TextBox
    Private WithEvents textv1_4 As TextBox
    Private WithEvents btnAddEdge4 As Button
    Private WithEvents AddNode4 As Button
    Private WithEvents txtAddNode4 As TextBox
    Private WithEvents label1 As Label
End Class

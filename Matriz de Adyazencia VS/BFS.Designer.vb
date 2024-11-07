<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BFS
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
        label8 = New Label()
        label7 = New Label()
        label6 = New Label()
        txtStartNode = New TextBox()
        btnBFS = New Button()
        seeMatrix3 = New Button()
        DTGmatrx3 = New DataGridView()
        label4 = New Label()
        label3 = New Label()
        txtvd2_3 = New TextBox()
        txtvd_3 = New TextBox()
        deleteedge3 = New Button()
        txtdeletenode3 = New TextBox()
        DeleteNode3 = New Button()
        label2 = New Label()
        textv2_3 = New TextBox()
        textv1_3 = New TextBox()
        btnAddEdge3 = New Button()
        AddNode3 = New Button()
        txtAddNode3 = New TextBox()
        label1 = New Label()
        CType(DTGmatrx3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Location = New Point(139, 196)
        label8.Name = "label8"
        label8.Size = New Size(31, 15)
        label8.TabIndex = 80
        label8.Text = "Start"
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Point(37, 369)
        label7.Name = "label7"
        label7.Size = New Size(19, 15)
        label7.TabIndex = 79
        label7.Text = "v1"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(162, 369)
        label6.Name = "label6"
        label6.Size = New Size(19, 15)
        label6.TabIndex = 78
        label6.Text = "v2"
        ' 
        ' txtStartNode
        ' 
        txtStartNode.Location = New Point(100, 214)
        txtStartNode.Name = "txtStartNode"
        txtStartNode.Size = New Size(100, 23)
        txtStartNode.TabIndex = 77
        ' 
        ' btnBFS
        ' 
        btnBFS.Location = New Point(9, 213)
        btnBFS.Name = "btnBFS"
        btnBFS.Size = New Size(75, 23)
        btnBFS.TabIndex = 76
        btnBFS.Text = "BFS"
        btnBFS.UseVisualStyleBackColor = True
        ' 
        ' seeMatrix3
        ' 
        seeMatrix3.Location = New Point(16, 417)
        seeMatrix3.Name = "seeMatrix3"
        seeMatrix3.Size = New Size(134, 23)
        seeMatrix3.TabIndex = 75
        seeMatrix3.Text = "See Matrix"
        seeMatrix3.UseVisualStyleBackColor = True
        ' 
        ' DTGmatrx3
        ' 
        DTGmatrx3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DTGmatrx3.Location = New Point(312, 11)
        DTGmatrx3.Name = "DTGmatrx3"
        DTGmatrx3.Size = New Size(480, 429)
        DTGmatrx3.TabIndex = 74
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(246, 108)
        label4.Name = "label4"
        label4.Size = New Size(20, 15)
        label4.TabIndex = 73
        label4.Text = "V2"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(130, 108)
        label3.Name = "label3"
        label3.Size = New Size(20, 15)
        label3.TabIndex = 72
        label3.Text = "V1"
        ' 
        ' txtvd2_3
        ' 
        txtvd2_3.Location = New Point(130, 343)
        txtvd2_3.Name = "txtvd2_3"
        txtvd2_3.Size = New Size(100, 23)
        txtvd2_3.TabIndex = 71
        ' 
        ' txtvd_3
        ' 
        txtvd_3.Location = New Point(9, 343)
        txtvd_3.Name = "txtvd_3"
        txtvd_3.Size = New Size(100, 23)
        txtvd_3.TabIndex = 70
        ' 
        ' deleteedge3
        ' 
        deleteedge3.Location = New Point(9, 314)
        deleteedge3.Name = "deleteedge3"
        deleteedge3.Size = New Size(89, 23)
        deleteedge3.TabIndex = 69
        deleteedge3.Text = "Delete Edge"
        deleteedge3.UseVisualStyleBackColor = True
        ' 
        ' txtdeletenode3
        ' 
        txtdeletenode3.Location = New Point(9, 285)
        txtdeletenode3.Name = "txtdeletenode3"
        txtdeletenode3.Size = New Size(100, 23)
        txtdeletenode3.TabIndex = 68
        ' 
        ' DeleteNode3
        ' 
        DeleteNode3.Location = New Point(12, 256)
        DeleteNode3.Name = "DeleteNode3"
        DeleteNode3.Size = New Size(89, 23)
        DeleteNode3.TabIndex = 67
        DeleteNode3.Text = "Delete Node"
        DeleteNode3.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(16, 98)
        label2.Name = "label2"
        label2.Size = New Size(33, 15)
        label2.TabIndex = 66
        label2.Text = "Edge"
        ' 
        ' textv2_3
        ' 
        textv2_3.Location = New Point(206, 126)
        textv2_3.Name = "textv2_3"
        textv2_3.Size = New Size(100, 23)
        textv2_3.TabIndex = 65
        ' 
        ' textv1_3
        ' 
        textv1_3.Location = New Point(100, 126)
        textv1_3.Name = "textv1_3"
        textv1_3.Size = New Size(100, 23)
        textv1_3.TabIndex = 64
        ' 
        ' btnAddEdge3
        ' 
        btnAddEdge3.Location = New Point(9, 126)
        btnAddEdge3.Name = "btnAddEdge3"
        btnAddEdge3.Size = New Size(75, 23)
        btnAddEdge3.TabIndex = 63
        btnAddEdge3.Text = "Add Edge"
        btnAddEdge3.UseVisualStyleBackColor = True
        ' 
        ' AddNode3
        ' 
        AddNode3.Location = New Point(9, 45)
        AddNode3.Name = "AddNode3"
        AddNode3.Size = New Size(75, 23)
        AddNode3.TabIndex = 62
        AddNode3.Text = "Add Node"
        AddNode3.UseVisualStyleBackColor = True
        ' 
        ' txtAddNode3
        ' 
        txtAddNode3.Location = New Point(100, 45)
        txtAddNode3.Name = "txtAddNode3"
        txtAddNode3.Size = New Size(100, 23)
        txtAddNode3.TabIndex = 61
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(16, 11)
        label1.Name = "label1"
        label1.Size = New Size(36, 15)
        label1.TabIndex = 60
        label1.Text = "Node"
        ' 
        ' BFS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(label8)
        Controls.Add(label7)
        Controls.Add(label6)
        Controls.Add(txtStartNode)
        Controls.Add(btnBFS)
        Controls.Add(seeMatrix3)
        Controls.Add(DTGmatrx3)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(txtvd2_3)
        Controls.Add(txtvd_3)
        Controls.Add(deleteedge3)
        Controls.Add(txtdeletenode3)
        Controls.Add(DeleteNode3)
        Controls.Add(label2)
        Controls.Add(textv2_3)
        Controls.Add(textv1_3)
        Controls.Add(btnAddEdge3)
        Controls.Add(AddNode3)
        Controls.Add(txtAddNode3)
        Controls.Add(label1)
        Name = "BFS"
        Text = "BFS"
        CType(DTGmatrx3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents txtStartNode As TextBox
    Private WithEvents btnBFS As Button
    Private WithEvents seeMatrix3 As Button
    Private WithEvents DTGmatrx3 As DataGridView
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtvd2_3 As TextBox
    Private WithEvents txtvd_3 As TextBox
    Private WithEvents deleteedge3 As Button
    Private WithEvents txtdeletenode3 As TextBox
    Private WithEvents DeleteNode3 As Button
    Private WithEvents label2 As Label
    Private WithEvents textv2_3 As TextBox
    Private WithEvents textv1_3 As TextBox
    Private WithEvents btnAddEdge3 As Button
    Private WithEvents AddNode3 As Button
    Private WithEvents txtAddNode3 As TextBox
    Private WithEvents label1 As Label
End Class

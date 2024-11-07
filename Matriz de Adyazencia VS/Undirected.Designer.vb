<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Undirected
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
        label6 = New Label()
        v1 = New Label()
        seeMatrix = New Button()
        DTGmatrx = New DataGridView()
        label5 = New Label()
        label4 = New Label()
        label3 = New Label()
        txtvd2 = New TextBox()
        txtvd = New TextBox()
        DeleteEdge = New Button()
        txtdeletenode = New TextBox()
        button3 = New Button()
        label2 = New Label()
        textweight = New TextBox()
        textv2 = New TextBox()
        textv1 = New TextBox()
        btnAddEdge = New Button()
        AddNode = New Button()
        txtAddNode = New TextBox()
        label1 = New Label()
        CType(DTGmatrx, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(162, 391)
        label6.Name = "label6"
        label6.Size = New Size(19, 15)
        label6.TabIndex = 40
        label6.Text = "v2"
        ' 
        ' v1
        ' 
        v1.AutoSize = True
        v1.Location = New Point(46, 391)
        v1.Name = "v1"
        v1.Size = New Size(19, 15)
        v1.TabIndex = 39
        v1.Text = "v1"
        ' 
        ' seeMatrix
        ' 
        seeMatrix.Location = New Point(16, 417)
        seeMatrix.Name = "seeMatrix"
        seeMatrix.Size = New Size(134, 23)
        seeMatrix.TabIndex = 38
        seeMatrix.Text = "See Matrix"
        seeMatrix.UseVisualStyleBackColor = True
        ' 
        ' DTGmatrx
        ' 
        DTGmatrx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DTGmatrx.Location = New Point(312, 11)
        DTGmatrx.Name = "DTGmatrx"
        DTGmatrx.Size = New Size(480, 429)
        DTGmatrx.TabIndex = 37
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(185, 199)
        label5.Name = "label5"
        label5.Size = New Size(45, 15)
        label5.TabIndex = 36
        label5.Text = "Weight"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(246, 108)
        label4.Name = "label4"
        label4.Size = New Size(20, 15)
        label4.TabIndex = 35
        label4.Text = "V2"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(130, 108)
        label3.Name = "label3"
        label3.Size = New Size(20, 15)
        label3.TabIndex = 34
        label3.Text = "V1"
        ' 
        ' txtvd2
        ' 
        txtvd2.Location = New Point(130, 365)
        txtvd2.Name = "txtvd2"
        txtvd2.Size = New Size(100, 23)
        txtvd2.TabIndex = 33
        ' 
        ' txtvd
        ' 
        txtvd.Location = New Point(9, 365)
        txtvd.Name = "txtvd"
        txtvd.Size = New Size(100, 23)
        txtvd.TabIndex = 32
        ' 
        ' DeleteEdge
        ' 
        DeleteEdge.Location = New Point(9, 316)
        DeleteEdge.Name = "DeleteEdge"
        DeleteEdge.Size = New Size(89, 23)
        DeleteEdge.TabIndex = 31
        DeleteEdge.Text = "Delete Edge"
        DeleteEdge.UseVisualStyleBackColor = True
        ' 
        ' txtdeletenode
        ' 
        txtdeletenode.Location = New Point(9, 274)
        txtdeletenode.Name = "txtdeletenode"
        txtdeletenode.Size = New Size(100, 23)
        txtdeletenode.TabIndex = 30
        ' 
        ' button3
        ' 
        button3.Location = New Point(9, 235)
        button3.Name = "button3"
        button3.Size = New Size(89, 23)
        button3.TabIndex = 29
        button3.Text = "Delete Node"
        button3.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(16, 98)
        label2.Name = "label2"
        label2.Size = New Size(33, 15)
        label2.TabIndex = 28
        label2.Text = "Edge"
        ' 
        ' textweight
        ' 
        textweight.Location = New Point(153, 173)
        textweight.Name = "textweight"
        textweight.Size = New Size(100, 23)
        textweight.TabIndex = 27
        ' 
        ' textv2
        ' 
        textv2.Location = New Point(206, 126)
        textv2.Name = "textv2"
        textv2.Size = New Size(100, 23)
        textv2.TabIndex = 26
        ' 
        ' textv1
        ' 
        textv1.Location = New Point(100, 126)
        textv1.Name = "textv1"
        textv1.Size = New Size(100, 23)
        textv1.TabIndex = 25
        ' 
        ' btnAddEdge
        ' 
        btnAddEdge.Location = New Point(9, 125)
        btnAddEdge.Name = "btnAddEdge"
        btnAddEdge.Size = New Size(75, 23)
        btnAddEdge.TabIndex = 24
        btnAddEdge.Text = "Add Edge"
        btnAddEdge.UseVisualStyleBackColor = True
        ' 
        ' AddNode
        ' 
        AddNode.Location = New Point(9, 45)
        AddNode.Name = "AddNode"
        AddNode.Size = New Size(75, 23)
        AddNode.TabIndex = 23
        AddNode.Text = "Add Node"
        AddNode.UseVisualStyleBackColor = True
        ' 
        ' txtAddNode
        ' 
        txtAddNode.Location = New Point(100, 45)
        txtAddNode.Name = "txtAddNode"
        txtAddNode.Size = New Size(100, 23)
        txtAddNode.TabIndex = 22
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(16, 11)
        label1.Name = "label1"
        label1.Size = New Size(36, 15)
        label1.TabIndex = 21
        label1.Text = "Node"
        ' 
        ' Undirected
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(label6)
        Controls.Add(v1)
        Controls.Add(seeMatrix)
        Controls.Add(DTGmatrx)
        Controls.Add(label5)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(txtvd2)
        Controls.Add(txtvd)
        Controls.Add(DeleteEdge)
        Controls.Add(txtdeletenode)
        Controls.Add(button3)
        Controls.Add(label2)
        Controls.Add(textweight)
        Controls.Add(textv2)
        Controls.Add(textv1)
        Controls.Add(btnAddEdge)
        Controls.Add(AddNode)
        Controls.Add(txtAddNode)
        Controls.Add(label1)
        Name = "Undirected"
        Text = "Undirected"
        CType(DTGmatrx, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label6 As Label
    Private WithEvents v1 As Label
    Private WithEvents seeMatrix As Button
    Private WithEvents DTGmatrx As DataGridView
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtvd2 As TextBox
    Private WithEvents txtvd As TextBox
    Private WithEvents DeleteEdge As Button
    Private WithEvents txtdeletenode As TextBox
    Private WithEvents button3 As Button
    Private WithEvents label2 As Label
    Private WithEvents textweight As TextBox
    Private WithEvents textv2 As TextBox
    Private WithEvents textv1 As TextBox
    Private WithEvents btnAddEdge As Button
    Private WithEvents AddNode As Button
    Private WithEvents txtAddNode As TextBox
    Private WithEvents label1 As Label
End Class

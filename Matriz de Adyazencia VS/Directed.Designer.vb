<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Directed
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
        label7 = New Label()
        label6 = New Label()
        seeMatrix2 = New Button()
        DTGmatrx2 = New DataGridView()
        label5 = New Label()
        label4 = New Label()
        label3 = New Label()
        txtvd2_2 = New TextBox()
        txtvd_2 = New TextBox()
        button4 = New Button()
        txtdeletenode2 = New TextBox()
        DeleteNode2 = New Button()
        label2 = New Label()
        textweight2 = New TextBox()
        textv2_2 = New TextBox()
        textv1_2 = New TextBox()
        btnAddEdge2 = New Button()
        AddNode2 = New Button()
        txtAddNode2 = New TextBox()
        label1 = New Label()
        CType(DTGmatrx2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Point(36, 394)
        label7.Name = "label7"
        label7.Size = New Size(19, 15)
        label7.TabIndex = 58
        label7.Text = "v1"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(162, 394)
        label6.Name = "label6"
        label6.Size = New Size(19, 15)
        label6.TabIndex = 57
        label6.Text = "v2"
        ' 
        ' seeMatrix2
        ' 
        seeMatrix2.Location = New Point(16, 417)
        seeMatrix2.Name = "seeMatrix2"
        seeMatrix2.Size = New Size(134, 23)
        seeMatrix2.TabIndex = 56
        seeMatrix2.Text = "See Matrix"
        seeMatrix2.UseVisualStyleBackColor = True
        ' 
        ' DTGmatrx2
        ' 
        DTGmatrx2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DTGmatrx2.Location = New Point(312, 11)
        DTGmatrx2.Name = "DTGmatrx2"
        DTGmatrx2.Size = New Size(480, 429)
        DTGmatrx2.TabIndex = 55
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(185, 199)
        label5.Name = "label5"
        label5.Size = New Size(45, 15)
        label5.TabIndex = 54
        label5.Text = "Weight"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(246, 108)
        label4.Name = "label4"
        label4.Size = New Size(20, 15)
        label4.TabIndex = 53
        label4.Text = "V2"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(130, 108)
        label3.Name = "label3"
        label3.Size = New Size(20, 15)
        label3.TabIndex = 52
        label3.Text = "V1"
        ' 
        ' txtvd2_2
        ' 
        txtvd2_2.Location = New Point(130, 365)
        txtvd2_2.Name = "txtvd2_2"
        txtvd2_2.Size = New Size(100, 23)
        txtvd2_2.TabIndex = 51
        ' 
        ' txtvd_2
        ' 
        txtvd_2.Location = New Point(9, 365)
        txtvd_2.Name = "txtvd_2"
        txtvd_2.Size = New Size(100, 23)
        txtvd_2.TabIndex = 50
        ' 
        ' button4
        ' 
        button4.Location = New Point(9, 316)
        button4.Name = "button4"
        button4.Size = New Size(89, 23)
        button4.TabIndex = 49
        button4.Text = "Delete Edge"
        button4.UseVisualStyleBackColor = True
        ' 
        ' txtdeletenode2
        ' 
        txtdeletenode2.Location = New Point(9, 274)
        txtdeletenode2.Name = "txtdeletenode2"
        txtdeletenode2.Size = New Size(100, 23)
        txtdeletenode2.TabIndex = 48
        ' 
        ' DeleteNode2
        ' 
        DeleteNode2.Location = New Point(9, 235)
        DeleteNode2.Name = "DeleteNode2"
        DeleteNode2.Size = New Size(89, 23)
        DeleteNode2.TabIndex = 47
        DeleteNode2.Text = "Delete Node"
        DeleteNode2.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(16, 98)
        label2.Name = "label2"
        label2.Size = New Size(33, 15)
        label2.TabIndex = 46
        label2.Text = "Edge"
        ' 
        ' textweight2
        ' 
        textweight2.Location = New Point(153, 173)
        textweight2.Name = "textweight2"
        textweight2.Size = New Size(100, 23)
        textweight2.TabIndex = 45
        ' 
        ' textv2_2
        ' 
        textv2_2.Location = New Point(206, 126)
        textv2_2.Name = "textv2_2"
        textv2_2.Size = New Size(100, 23)
        textv2_2.TabIndex = 44
        ' 
        ' textv1_2
        ' 
        textv1_2.Location = New Point(100, 126)
        textv1_2.Name = "textv1_2"
        textv1_2.Size = New Size(100, 23)
        textv1_2.TabIndex = 43
        ' 
        ' btnAddEdge2
        ' 
        btnAddEdge2.Location = New Point(9, 125)
        btnAddEdge2.Name = "btnAddEdge2"
        btnAddEdge2.Size = New Size(75, 23)
        btnAddEdge2.TabIndex = 42
        btnAddEdge2.Text = "Add Edge"
        btnAddEdge2.UseVisualStyleBackColor = True
        ' 
        ' AddNode2
        ' 
        AddNode2.Location = New Point(9, 45)
        AddNode2.Name = "AddNode2"
        AddNode2.Size = New Size(75, 23)
        AddNode2.TabIndex = 41
        AddNode2.Text = "Add Node"
        AddNode2.UseVisualStyleBackColor = True
        ' 
        ' txtAddNode2
        ' 
        txtAddNode2.Location = New Point(100, 45)
        txtAddNode2.Name = "txtAddNode2"
        txtAddNode2.Size = New Size(100, 23)
        txtAddNode2.TabIndex = 40
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(16, 11)
        label1.Name = "label1"
        label1.Size = New Size(36, 15)
        label1.TabIndex = 39
        label1.Text = "Node"
        ' 
        ' Directed
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(label7)
        Controls.Add(label6)
        Controls.Add(seeMatrix2)
        Controls.Add(DTGmatrx2)
        Controls.Add(label5)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(txtvd2_2)
        Controls.Add(txtvd_2)
        Controls.Add(button4)
        Controls.Add(txtdeletenode2)
        Controls.Add(DeleteNode2)
        Controls.Add(label2)
        Controls.Add(textweight2)
        Controls.Add(textv2_2)
        Controls.Add(textv1_2)
        Controls.Add(btnAddEdge2)
        Controls.Add(AddNode2)
        Controls.Add(txtAddNode2)
        Controls.Add(label1)
        Name = "Directed"
        Text = "Directed"
        CType(DTGmatrx2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents seeMatrix2 As Button
    Private WithEvents DTGmatrx2 As DataGridView
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtvd2_2 As TextBox
    Private WithEvents txtvd_2 As TextBox
    Private WithEvents button4 As Button
    Private WithEvents txtdeletenode2 As TextBox
    Private WithEvents DeleteNode2 As Button
    Private WithEvents label2 As Label
    Private WithEvents textweight2 As TextBox
    Private WithEvents textv2_2 As TextBox
    Private WithEvents textv1_2 As TextBox
    Private WithEvents btnAddEdge2 As Button
    Private WithEvents AddNode2 As Button
    Private WithEvents txtAddNode2 As TextBox
    Private WithEvents label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        containerpanel = New Panel()
        panel1 = New Panel()
        label1 = New Label()
        button4 = New Button()
        button3 = New Button()
        Directed = New Button()
        UndirectedBtn = New Button()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' containerpanel
        ' 
        containerpanel.Location = New Point(183, -1)
        containerpanel.Name = "containerpanel"
        containerpanel.Size = New Size(825, 578)
        containerpanel.TabIndex = 3
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.DeepSkyBlue
        panel1.Controls.Add(label1)
        panel1.Controls.Add(button4)
        panel1.Controls.Add(button3)
        panel1.Controls.Add(Directed)
        panel1.Controls.Add(UndirectedBtn)
        panel1.Location = New Point(1, -1)
        panel1.Name = "panel1"
        panel1.Size = New Size(184, 578)
        panel1.TabIndex = 2
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(27, 8)
        label1.Name = "label1"
        label1.Size = New Size(132, 45)
        label1.TabIndex = 1
        label1.Text = "GRAPH"
        ' 
        ' button4
        ' 
        button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        button4.Location = New Point(11, 461)
        button4.Name = "button4"
        button4.Size = New Size(165, 23)
        button4.TabIndex = 4
        button4.Text = "DFS"
        button4.UseVisualStyleBackColor = True
        ' 
        ' button3
        ' 
        button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        button3.Location = New Point(11, 332)
        button3.Name = "button3"
        button3.Size = New Size(165, 23)
        button3.TabIndex = 3
        button3.Text = "BFS"
        button3.UseVisualStyleBackColor = True
        ' 
        ' Directed
        ' 
        Directed.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Directed.Location = New Point(11, 190)
        Directed.Name = "Directed"
        Directed.Size = New Size(165, 23)
        Directed.TabIndex = 2
        Directed.Text = "Directed"
        Directed.UseVisualStyleBackColor = True
        ' 
        ' UndirectedBtn
        ' 
        UndirectedBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UndirectedBtn.Location = New Point(11, 72)
        UndirectedBtn.Name = "UndirectedBtn"
        UndirectedBtn.Size = New Size(165, 23)
        UndirectedBtn.TabIndex = 1
        UndirectedBtn.Text = "Undirected"
        UndirectedBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1010, 576)
        Controls.Add(containerpanel)
        Controls.Add(panel1)
        Name = "Form1"
        Text = "Form1"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents containerpanel As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents label1 As Label
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents Directed As Button
    Private WithEvents UndirectedBtn As Button

End Class

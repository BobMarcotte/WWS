<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CODENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwbullsviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BULLSDataSet = New WWS.BULLSDataSet()
        Me.Vw_bulls_viewTableAdapter = New WWS.BULLSDataSetTableAdapters.vw_bulls_viewTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwbullsviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BULLSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODENODataGridViewTextBoxColumn, Me.CODENAMEDataGridViewTextBoxColumn, Me.REGNAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.PtamDataGridViewTextBoxColumn, Me.PtapDataGridViewTextBoxColumn, Me.PTATDataGridViewTextBoxColumn, Me.TpiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwbullsviewBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(669, 233)
        Me.DataGridView1.TabIndex = 0
        '
        'CODENODataGridViewTextBoxColumn
        '
        Me.CODENODataGridViewTextBoxColumn.DataPropertyName = "CODENO"
        Me.CODENODataGridViewTextBoxColumn.HeaderText = "CODENO"
        Me.CODENODataGridViewTextBoxColumn.Name = "CODENODataGridViewTextBoxColumn"
        '
        'CODENAMEDataGridViewTextBoxColumn
        '
        Me.CODENAMEDataGridViewTextBoxColumn.DataPropertyName = "CODENAME"
        Me.CODENAMEDataGridViewTextBoxColumn.HeaderText = "CODENAME"
        Me.CODENAMEDataGridViewTextBoxColumn.Name = "CODENAMEDataGridViewTextBoxColumn"
        '
        'REGNAMEDataGridViewTextBoxColumn
        '
        Me.REGNAMEDataGridViewTextBoxColumn.DataPropertyName = "REGNAME"
        Me.REGNAMEDataGridViewTextBoxColumn.HeaderText = "REGNAME"
        Me.REGNAMEDataGridViewTextBoxColumn.Name = "REGNAMEDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'PtamDataGridViewTextBoxColumn
        '
        Me.PtamDataGridViewTextBoxColumn.DataPropertyName = "Ptam"
        Me.PtamDataGridViewTextBoxColumn.HeaderText = "Ptam"
        Me.PtamDataGridViewTextBoxColumn.Name = "PtamDataGridViewTextBoxColumn"
        '
        'PtapDataGridViewTextBoxColumn
        '
        Me.PtapDataGridViewTextBoxColumn.DataPropertyName = "Ptap"
        Me.PtapDataGridViewTextBoxColumn.HeaderText = "Ptap"
        Me.PtapDataGridViewTextBoxColumn.Name = "PtapDataGridViewTextBoxColumn"
        '
        'PTATDataGridViewTextBoxColumn
        '
        Me.PTATDataGridViewTextBoxColumn.DataPropertyName = "PTAT"
        Me.PTATDataGridViewTextBoxColumn.HeaderText = "PTAT"
        Me.PTATDataGridViewTextBoxColumn.Name = "PTATDataGridViewTextBoxColumn"
        '
        'TpiDataGridViewTextBoxColumn
        '
        Me.TpiDataGridViewTextBoxColumn.DataPropertyName = "Tpi"
        Me.TpiDataGridViewTextBoxColumn.HeaderText = "Tpi"
        Me.TpiDataGridViewTextBoxColumn.Name = "TpiDataGridViewTextBoxColumn"
        '
        'VwbullsviewBindingSource
        '
        Me.VwbullsviewBindingSource.DataMember = "vw_bulls_view"
        Me.VwbullsviewBindingSource.DataSource = Me.BULLSDataSet
        '
        'BULLSDataSet
        '
        Me.BULLSDataSet.DataSetName = "BULLSDataSet"
        Me.BULLSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_bulls_viewTableAdapter
        '
        Me.Vw_bulls_viewTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Filter by TPI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(282, 356)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(282, 406)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 452)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Filter"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(585, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Filter by Active"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "     "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(585, 452)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(206, 281)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Filter by Codename"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(401, 281)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Filter by CodeNumber"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 511)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "World Wide Sires"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwbullsviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BULLSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BULLSDataSet As BULLSDataSet
    Friend WithEvents VwbullsviewBindingSource As BindingSource
    Friend WithEvents Vw_bulls_viewTableAdapter As BULLSDataSetTableAdapters.vw_bulls_viewTableAdapter
    Friend WithEvents CODENODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REGNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PtamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PtapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PTATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TpiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class

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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtWorkAdress = New System.Windows.Forms.TextBox()
        Me.txtHomeAdress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNotice = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTitleID = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgV = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.work_adress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.home_adress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.number1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.number2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.job_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(772, 508)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(140, 50)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(679, 33)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 23)
        Me.txtName.TabIndex = 3
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWorkAdress
        '
        Me.txtWorkAdress.Location = New System.Drawing.Point(679, 65)
        Me.txtWorkAdress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWorkAdress.Name = "txtWorkAdress"
        Me.txtWorkAdress.Size = New System.Drawing.Size(207, 23)
        Me.txtWorkAdress.TabIndex = 4
        Me.txtWorkAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHomeAdress
        '
        Me.txtHomeAdress.Location = New System.Drawing.Point(679, 97)
        Me.txtHomeAdress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHomeAdress.Name = "txtHomeAdress"
        Me.txtHomeAdress.Size = New System.Drawing.Size(207, 23)
        Me.txtHomeAdress.TabIndex = 5
        Me.txtHomeAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(679, 129)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(207, 23)
        Me.txtCity.TabIndex = 6
        Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(679, 161)
        Me.txtNumber1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(207, 23)
        Me.txtNumber1.TabIndex = 7
        Me.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(679, 193)
        Me.txtNumber2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(207, 23)
        Me.txtNumber2.TabIndex = 8
        Me.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNotice
        '
        Me.txtNotice.Location = New System.Drawing.Point(210, 126)
        Me.txtNotice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNotice.Name = "txtNotice"
        Me.txtNotice.Size = New System.Drawing.Size(207, 23)
        Me.txtNotice.TabIndex = 13
        Me.txtNotice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(210, 95)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(207, 23)
        Me.txtEmail.TabIndex = 12
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitleID
        '
        Me.txtTitleID.Location = New System.Drawing.Point(210, 64)
        Me.txtTitleID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitleID.Name = "txtTitleID"
        Me.txtTitleID.Size = New System.Drawing.Size(207, 23)
        Me.txtTitleID.TabIndex = 11
        Me.txtTitleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(210, 33)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(207, 23)
        Me.txtTitle.TabIndex = 10
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(894, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "الاسم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(894, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "عنوان العمل"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(894, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "عنوان المنزل"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(894, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "المدينة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(894, 159)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "رقم الهاتف 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(892, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "رقم الهاتف 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(425, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "المسمي الوظيفي"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(425, 71)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "الرقم الوظيفي"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(425, 102)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "البريد الالكتروني"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(425, 133)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ملاحظات"
        '
        'dgV
        '
        Me.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.name, Me.work_adress, Me.home_adress, Me.city, Me.number1, Me.number2, Me.title, Me.job_id, Me.email, Me.notice})
        Me.dgV.Location = New System.Drawing.Point(86, 277)
        Me.dgV.Name = "dgV"
        Me.dgV.ReadOnly = True
        Me.dgV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgV.RowHeadersVisible = False
        Me.dgV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgV.Size = New System.Drawing.Size(1025, 210)
        Me.dgV.TabIndex = 29
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id.HeaderText = "كود"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 54
        '
        'name
        '
        Me.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.name.HeaderText = "الاسم"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        Me.name.Width = 70
        '
        'work_adress
        '
        Me.work_adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.work_adress.HeaderText = "عنوان العمل"
        Me.work_adress.Name = "work_adress"
        Me.work_adress.ReadOnly = True
        Me.work_adress.Width = 99
        '
        'home_adress
        '
        Me.home_adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.home_adress.HeaderText = "عنوان المنزل"
        Me.home_adress.Name = "home_adress"
        Me.home_adress.ReadOnly = True
        Me.home_adress.Width = 102
        '
        'city
        '
        Me.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.city.HeaderText = "المدينة"
        Me.city.Name = "city"
        Me.city.ReadOnly = True
        Me.city.Width = 75
        '
        'number1
        '
        Me.number1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.number1.HeaderText = "رقم الهاتف 1"
        Me.number1.Name = "number1"
        Me.number1.ReadOnly = True
        Me.number1.Width = 90
        '
        'number2
        '
        Me.number2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.number2.HeaderText = "رقم الهاتف 2"
        Me.number2.Name = "number2"
        Me.number2.ReadOnly = True
        Me.number2.Width = 90
        '
        'title
        '
        Me.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.title.HeaderText = "المسمي الوظيفي"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 133
        '
        'job_id
        '
        Me.job_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.job_id.HeaderText = "الرقم الوظيفي"
        Me.job_id.Name = "job_id"
        Me.job_id.ReadOnly = True
        Me.job_id.Width = 112
        '
        'email
        '
        Me.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.email.HeaderText = "البريد الالكتروني"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 120
        '
        'notice
        '
        Me.notice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.notice.HeaderText = "ملاحظات"
        Me.notice.Name = "notice"
        Me.notice.ReadOnly = True
        Me.notice.Width = 87
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(768, 239)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 23)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "بحث"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(915, 239)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 23)
        Me.txtSearch.TabIndex = 32
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(285, 508)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 50)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "تعديل البيانات"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1007, 508)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 50)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "حفظ التسجيل"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(50, 508)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 50)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "اغلاق"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(520, 508)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(157, 50)
        Me.btnReset.TabIndex = 37
        Me.btnReset.Text = "اضافة بيانات جديدة"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(341, 182)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(55, 16)
        Me.lblID.TabIndex = 38
        Me.lblID.Text = "id-label"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 611)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgV)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNotice)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTitleID)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtHomeAdress)
        Me.Controls.Add(Me.txtWorkAdress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnDelete)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        'Me.name = "Form1"
        Me.Text = "دليل اتصال"
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtWorkAdress As TextBox
    Friend WithEvents txtHomeAdress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtNotice As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTitleID As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgV As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents work_adress As DataGridViewTextBoxColumn
    Friend WithEvents home_adress As DataGridViewTextBoxColumn
    Friend WithEvents city As DataGridViewTextBoxColumn
    Friend WithEvents number1 As DataGridViewTextBoxColumn
    Friend WithEvents number2 As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents job_id As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents notice As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblID As Label
End Class

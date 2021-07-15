Imports System.Data.SqlClient
Imports System.IO
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtWorkAddress_TextChanged(sender As Object, e As EventArgs) Handles txtWorkAdress.TextChanged

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblSet.Text = "add" Then
            SaveData()
        Else
            If lblSet.Text = "update" Then
                UpdateData()

            End If

        End If
    End Sub
    Sub SaveData()
        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل الاسم", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            'txtName.Select()
            Exit Sub
        End If

        If Len(Trim(txtWorkAdress.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل عنوان العمل", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWorkAdress.Focus()
            'txtWorkAdress.Select()
            Exit Sub
        End If

        If Len(Trim(txtHomeAdress.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل عنوان المنزل", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHomeAdress.Focus()
            'txtHomeAdress.Select()
            Exit Sub
        End If

        If Len(Trim(txtCity.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل المدينة", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCity.Focus()
            'txtCity.Select()
            Exit Sub
        End If

        If Len(Trim(txtNumber1.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل رقم الهاتف الأول", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumber1.Focus()
            'txtNumber1.Select()
            Exit Sub
        End If

        'If Len(Trim(txtNumber2.Text)) = 0 Then
        '    MessageBox.Show("من فضلك ادخل رقم الهاتف الثاني")
        '    txtNumber2.Focus()
        '    'txtNumber2.Select()
        '    Exit Sub
        'End If

        If Len(Trim(txtTitle.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل المسمي الوظيفي", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitle.Focus()
            'txtTitle.Select()
            Exit Sub
        End If

        If Len(Trim(txtTitleID.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل الرقم الوظيفي", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitleID.Focus()
            'txtTitleID.Select()
            Exit Sub
        End If

        If Len(Trim(txtEmail.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل البريد الالكتروني", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            'txtEmail.Select()
            Exit Sub
        End If

        'If Len(Trim(txtNotice.Text)) = 0 Then
        '    MessageBox.Show("من فضلك ادخل ملاحظات ان وجدت")
        '    txtNotice.Focus()
        '    'txtNotice.Select()
        '    Exit Sub
        'End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into Table_1(name,work_adress,home_adress,city,number1,number2,title,job_id,email,notice) 
                                                   values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtName.Text)
            cmd.Parameters.AddWithValue("@d2", txtWorkAdress.Text)
            cmd.Parameters.AddWithValue("@d3", txtHomeAdress.Text)
            cmd.Parameters.AddWithValue("@d4", txtCity.Text)
            cmd.Parameters.AddWithValue("@d5", txtNumber1.Text)
            cmd.Parameters.AddWithValue("@d6", txtNumber2.Text)
            cmd.Parameters.AddWithValue("@d7", txtTitle.Text)
            cmd.Parameters.AddWithValue("@d8", txtTitleID.Text)
            cmd.Parameters.AddWithValue("@d9", txtEmail.Text)
            cmd.Parameters.AddWithValue("@d10", txtNotice.Text)
            'To connect the excute to the main con'
            cmd.Connection = con
            Dim ms As New MemoryStream
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("تم الحفظ بنجاح")
            Form1.GetData()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub UpdateData()
        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل الاسم", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            'txtName.Select()
            Exit Sub
        End If

        If Len(Trim(txtWorkAdress.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل عنوان العمل", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWorkAdress.Focus()
            'txtWorkAdress.Select()
            Exit Sub
        End If

        If Len(Trim(txtHomeAdress.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل عنوان المنزل", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHomeAdress.Focus()
            'txtHomeAdress.Select()
            Exit Sub
        End If

        If Len(Trim(txtCity.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل المدينة", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCity.Focus()
            'txtCity.Select()
            Exit Sub
        End If

        If Len(Trim(txtNumber1.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل رقم الهاتف الأول", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumber1.Focus()
            'txtNumber1.Select()
            Exit Sub
        End If

        'If Len(Trim(txtNumber2.Text)) = 0 Then
        '    MessageBox.Show("من فضلك ادخل رقم الهاتف الثاني")
        '    txtNumber2.Focus()
        '    'txtNumber2.Select()
        '    Exit Sub
        'End If

        If Len(Trim(txtTitle.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل المسمي الوظيفي", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitle.Focus()
            'txtTitle.Select()
            Exit Sub
        End If

        If Len(Trim(txtTitleID.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل الرقم الوظيفي", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitleID.Focus()
            'txtTitleID.Select()
            Exit Sub
        End If

        If Len(Trim(txtEmail.Text)) = 0 Then
            MessageBox.Show("من فضلك ادخل البريد الالكتروني", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            'txtEmail.Select()
            Exit Sub
        End If

        'If Len(Trim(txtNotice.Text)) = 0 Then
        '    MessageBox.Show("من فضلك ادخل ملاحظات ان وجدت")
        '    txtNotice.Focus()
        '    'txtNotice.Select()
        '    Exit Sub
        'End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "update Table_1 set name=@d1,
                                work_adress=@d2,
                                home_adress=@d3,
                                city=@d4,
                                number1=@d5,
                                number2=@d6,
                                title=@d7,
                                job_id=@d8,
                                email=@d9,
                                notice=@d10 where id =@d11"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtName.Text)
            cmd.Parameters.AddWithValue("@d2", txtWorkAdress.Text)
            cmd.Parameters.AddWithValue("@d3", txtHomeAdress.Text)
            cmd.Parameters.AddWithValue("@d4", txtCity.Text)
            cmd.Parameters.AddWithValue("@d5", txtNumber1.Text)
            cmd.Parameters.AddWithValue("@d6", txtNumber2.Text)
            cmd.Parameters.AddWithValue("@d7", txtTitle.Text)
            cmd.Parameters.AddWithValue("@d8", txtTitleID.Text)
            cmd.Parameters.AddWithValue("@d9", txtEmail.Text)
            cmd.Parameters.AddWithValue("@d10", txtNotice.Text)
            cmd.Parameters.AddWithValue("@d11", Form1.lblID.Text)
            'To connect the excute to the main con'
            cmd.Connection = con
            Dim ms As New MemoryStream
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("تم الحفظ بنجاح")
            Form1.GetData()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Reset()
        txtName.Text = ""
        txtWorkAdress.Text = ""
        txtHomeAdress.Text = ""
        txtCity.Text = ""
        txtNumber1.Text = ""
        txtNumber2.Text = ""
        txtTitle.Text = ""
        txtTitleID.Text = ""
        txtEmail.Text = ""
        txtNotice.Text = ""
        lblSet.Text = ""
    End Sub
End Class
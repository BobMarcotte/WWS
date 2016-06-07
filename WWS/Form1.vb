Imports System.Data.SqlClient
Imports System.Data




Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BULLSDataSet.vw_bulls_view' table. You can move, or remove it, as needed.
        Me.Vw_bulls_viewTableAdapter.Fill(Me.BULLSDataSet.vw_bulls_view)

    End Sub

    Public Class GlobalVariables
        Public Shared Property Direction As String
        Public Shared Property tpi As Int32
        Public Shared Property active As String
        Public Shared Property codename As String
        Public Shared Property codenumber As String
        Public Shared Property FromButton As String



    End Class

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        GlobalVariables.Direction = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If GlobalVariables.FromButton = "TPI" Then
            GlobalVariables.Direction = TextBox1.Text
            GlobalVariables.tpi = TextBox2.Text



            Using con As New SqlConnection("Data Source = dbclass \ sqlexpress;Initial Catalog=BULLS;Integrated Security=True")
                con.Open()

                Using cmd As New SqlCommand("sp_tpi_filter", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@direction", GlobalVariables.Direction)
                    cmd.Parameters.AddWithValue("@tpi", GlobalVariables.tpi)

                    Using da As New SqlDataAdapter(cmd)

                        Using ds As New DataSet()
                            da.Fill(ds)
                            DataGridView1.DataSource = ds.Tables(0)

                        End Using


                    End Using
                End Using
                con.Close()

                GlobalVariables.Direction = ""
                GlobalVariables.tpi = Nothing
            End Using

            Label1.Visible = False
            Label2.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button2.Visible = False

        End If

        If GlobalVariables.FromButton = "Active" Then

            GlobalVariables.active = TextBox1.Text

            Using con As New SqlConnection("Data Source = dbclass \ sqlexpress;Initial Catalog=BULLS;Integrated Security=True")
                con.Open()

                Using cmd As New SqlCommand("sp_active_filter", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@active", GlobalVariables.active)


                    Using da As New SqlDataAdapter(cmd)

                        Using ds As New DataSet()
                            da.Fill(ds)
                            DataGridView1.DataSource = ds.Tables(0)

                        End Using


                    End Using
                End Using
                con.Close()

            End Using
            GlobalVariables.active = ""

        End If

        Label1.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button2.Visible = False

        If GlobalVariables.FromButton = "Codename" Then

            GlobalVariables.codename = TextBox1.Text

            Using con As New SqlConnection("Data Source = dbclass \ sqlexpress;Initial Catalog=BULLS;Integrated Security=True")
                con.Open()

                Using cmd As New SqlCommand("sp_codename_filter", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@codename", GlobalVariables.codename)


                    Using da As New SqlDataAdapter(cmd)

                        Using ds As New DataSet()
                            da.Fill(ds)
                            DataGridView1.DataSource = ds.Tables(0)

                        End Using


                    End Using
                End Using
                con.Close()

            End Using
            GlobalVariables.codename = ""
            TextBox1.Text = ""


        End If

        If GlobalVariables.FromButton = "Codenumber" Then

            GlobalVariables.codenumber = TextBox1.Text

            Using con As New SqlConnection("Data Source = dbclass \ sqlexpress;Initial Catalog=BULLS;Integrated Security=True")
                con.Open()

                Using cmd As New SqlCommand("sp_codeno_filter", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@code", GlobalVariables.codenumber)


                    Using da As New SqlDataAdapter(cmd)

                        Using ds As New DataSet()
                            da.Fill(ds)
                            DataGridView1.DataSource = ds.Tables(0)

                        End Using


                    End Using
                End Using
                con.Close()

            End Using
            GlobalVariables.codenumber = ""
            TextBox1.Text = ""


        End If




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = " + for up, - for down, leave empty to get records with no tpi"
        Label2.Text = " Enter TPI"
        Label1.Visible = True
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Text = 0
        TextBox2.Visible = True
        Button2.Visible = True
        GlobalVariables.FromButton = "TPI"
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        GlobalVariables.Direction = TextBox1.Text
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "1=active, 0=inactive, blank for all"
        Label1.Visible = True
        TextBox1.Visible = True
        Button2.Visible = True
        GlobalVariables.FromButton = "Active"


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GlobalVariables.FromButton = "Codename"
        Label1.Text = "Enter first few letters of name (no need for * )"
        Label1.Visible = True
        TextBox1.Visible = True
        Button2.Visible = True



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GlobalVariables.FromButton = "Codenumber"
        Label1.Text = "Enter first few numbers of code (no need for * )"
        Label1.Visible = True
        TextBox1.Visible = True
        Button2.Visible = True
    End Sub
End Class

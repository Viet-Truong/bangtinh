Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cong.Checked Then
            If value1.Text <> "" And value2.Text <> "" And value3.Text <> "" Then
                result.Text = CDbl(value1.Text) + CDbl(value2.Text) + CDbl(value3.Text)
            ElseIf value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) + CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf tru.Checked Then
            If value1.Text <> "" And value2.Text <> "" And value3.Text <> "" Then
                result.Text = CDbl(value1.Text) - CDbl(value2.Text) - CDbl(value3.Text)
            ElseIf value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) - CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf nhan.Checked Then
            If value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) * CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf chia.Checked Then
            If value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) / CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf chiaMod.Checked Then
            If value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) Mod CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf luythua.Checked Then
            If value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) ^ CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf chiaNguyen.Checked Then
            If value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) \ CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If chunhat.Checked Then
            If value1.Text <> "" And value2.Text <> "" Then
                result.Text = CDbl(value1.Text) * CDbl(value2.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf vuong.Checked Then
            If value3.Text <> "" Then
                result.Text = CDbl(value3.Text) * CDbl(value3.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf tamgiac.Checked Then
            If value1.Text <> "" And value2.Text <> "" And value3.Text <> "" Then
                Dim p As Double = (CDbl(value1.Text) + CDbl(value2.Text) + CDbl(value3.Text)) / 2
                result.Text = Math.Sqrt(p * (p - value1.Text) * (p - value2.Text) * (p - value3.Text))
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        ElseIf tron.Checked Then
            If value3.Text <> "" Then
                result.Text = Math.PI * CDbl(value3.Text) * CDbl(value3.Text)
            Else
                MessageBox.Show("Vui lòng nhập đủ các giá trị")
            End If
        End If
    End Sub
End Class

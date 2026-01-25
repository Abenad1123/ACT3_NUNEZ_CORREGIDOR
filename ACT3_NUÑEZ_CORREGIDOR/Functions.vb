Public Class Basic
    Public Shared Sub ImgHover(pb As PictureBox, Img As Image, hoverImg As Image)

        AddHandler pb.MouseEnter,
            Sub(sender As Object, e As EventArgs)
                CType(sender, PictureBox).Image = hoverImg
            End Sub

        AddHandler pb.MouseLeave,
            Sub(sender As Object, e As EventArgs)
                CType(sender, PictureBox).Image = Img
            End Sub

    End Sub

    Public Shared Sub ImgWidthWrap(ctrl As Control, parentCtrl As Control)
        ctrl.Width = parentCtrl.ClientSize.Width - ctrl.Margin.Left - ctrl.Margin.Right
    End Sub

    Public Shared Sub AlignX(ctrl As Control, parentCtrl As Control)
        ctrl.Left = CInt((parentCtrl.ClientSize.Width - ctrl.Width) \ 2)
    End Sub

    Public Shared Sub AlignY(ctrl As Control, parentCtrl As Control, percent As Single)
        ctrl.Top = CInt((parentCtrl.ClientSize.Height - ctrl.Height) * percent)
    End Sub

End Class
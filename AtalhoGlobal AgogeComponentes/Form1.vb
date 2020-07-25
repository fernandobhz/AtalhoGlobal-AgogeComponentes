Public Class Form1
    Inherits AgogeComponents.Formulario

    Sub New()
        Me.InitializeComponent()
        Me.RegistrarAtalhoGlobal(AgogeComponents.HKey.Mods.Shift Or AgogeComponents.HKey.Mods.Ctrl, Keys.I, AddressOf Me.Iniciar)
    End Sub


    Sub Iniciar()
        Me.FocusMe()
        MsgBox("OI")
        'Dim f As New Form
        'f.ShowDialog()
    End Sub

End Class

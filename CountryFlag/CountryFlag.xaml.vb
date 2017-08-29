Class CountryFlag
    Public Property Code() As CountryCode
        Get
            Return CType(GetValue(CodeProperty), CountryCode)
        End Get
        Set(ByVal value As CountryCode)
            SetValue(CodeProperty, value)
        End Set
    End Property

    Public Shared CodeProperty As DependencyProperty =
        DependencyProperty.Register("Code", GetType(CountryCode), GetType(CountryFlag),
                                    New PropertyMetadata(CountryCode.AD,
                                                         New PropertyChangedCallback(AddressOf ChangeFlag)))

    Private Shared Sub ChangeFlag(ByVal source As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
        Dim countryCode = CType(e.NewValue, CountryCode).ToString()
        Dim flag = "Flags/" & countryCode & ".png"
        CType(source, CountryFlag).Flag.Source = New BitmapImage(New Uri(flag, UriKind.Relative))
    End Sub
End Class

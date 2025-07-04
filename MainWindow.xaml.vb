
Imports System.Collections.ObjectModel
Imports System.Security.Policy
Class MainWindow
    Public Class AnchorItem
        Public Property Id As Integer
        Public Property Parent As String
        Public Property Type As String
        Public Property Pattern As String
        Public Property Margin As String
        Public Property Position As String
    End Class

    Public Class FieldItem
        Public Property Name As String
        Public Property LA As String
        Public Property TA As String
        Public Property RA As String
        Public Property BA As String
        Public Property Type As String
        Public Property Value As String
    End Class

    Public Class ConditionItem
        Public Property Name As String
        Public Property Expression As String
    End Class

    Public Property AnchorItems As List(Of AnchorItem)
    Public Property ConditionItems As List(Of ConditionItem)
    Public Property FieldItems As List(Of FieldItem)
    Public Property ParentOptions As List(Of String)
    Public Property TypeOptions As List(Of String)

    Public Property LAOptions As List(Of String)
    Public Property TAOptions As List(Of String)

    Public Property RAOptions As List(Of String)

    Public Property BAOptions As List(Of String)

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ParentOptions = New List(Of String) From {"", "Root", "Block1"}
        TypeOptions = New List(Of String) From {"PdfText"}
        LAOptions = New List(Of String) From {"", "Root", "Block1"}
        TAOptions = New List(Of String) From {"", "Root", "Block1"}
        RAOptions = New List(Of String) From {"", "Root", "Block1"}
        BAOptions = New List(Of String) From {"", "Root", "Block1"}

        AnchorItems = New List(Of AnchorItem) From {
            New AnchorItem With {.Id = 1, .Parent = "", .Type = "PdfText", .Pattern = "Credit Note", .Margin = "-", .Position = "{ X: 242.0, Y: 13.0 }"},
            New AnchorItem With {.Id = 2, .Parent = "", .Type = "PdfText", .Pattern = "BANK DETAILS", .Margin = "-", .Position = "{ X: 20.0, Y: 660.0 }"}
        }

        FieldItems = New List(Of FieldItem) From {
            New FieldItem With {.Name = "InvoiceId", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText", .Value = "CN-000000238"},
            New FieldItem With {.Name = "CustomerPin", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerName", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText", .Value = "ARK CONSTR"},
            New FieldItem With {.Name = "CustomerHQ", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerAdd", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerPostal", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerExemption", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "DollarPrice", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerHSCode", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerEmail", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "ReferenceInvoiceId", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "Kralnv", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"},
            New FieldItem With {.Name = "ProductTable", .LA = "", .TA = "", .RA = "", .BA = "", .Type = "PdfText"}
        }

        ConditionItems = New List(Of ConditionItem) From {
            New ConditionItem With {.Name = "FirstPageOfDocument", .Expression = "1"},
            New ConditionItem With {.Name = "LastPageOfDocument", .Expression = "2"}
        }

        AnchorGrid.DataContext = Me
        FieldsGrid.DataContext = Me
        ConditionsGrid.DataContext = Me
        AnchorGrid.ItemsSource = AnchorItems
        FieldsGrid.ItemsSource = FieldItems
        ConditionsGrid.ItemsSource = ConditionItems

        ParentColumn.ItemsSource = ParentOptions
        Type1Column.ItemsSource = TypeOptions
        Type2Column.ItemsSource = TypeOptions
        LAColumn.ItemsSource = LAOptions
        TAColumn.ItemsSource = TAOptions
        RAColumn.ItemsSource = RAOptions
        BAColumn.ItemsSource = BAOptions
    End Sub

    Private Sub Hyperlink_RequestNavigate(sender As Object, e As RequestNavigateEventArgs)
        Process.Start(New ProcessStartInfo(e.Uri.AbsoluteUri) With {
            .UseShellExecute = True
        })
        e.Handled = True
    End Sub

End Class





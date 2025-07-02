
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Windows.Navigation

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
    Public Property LA As Boolean
    Public Property TA As Boolean
    Public Property RA As Boolean
    Public Property BA As Boolean
    Public Property Type As String
    Public Property Value As String
End Class

Public Class ConditionItem
    Public Property Name As String
    Public Property Expression As String
End Class

Class MainWindow
    Public Property AnchorItems As ObservableCollection(Of AnchorItem)
    Public Property ConditionItems As ObservableCollection(Of ConditionItem)
    Public Property FieldItems As ObservableCollection(Of FieldItem)

    Public ReadOnly Property ParentOptions As List(Of String)
        Get
            Return New List(Of String) From {"", "Root", "Block1"}
        End Get
    End Property

    Public ReadOnly Property TypeOptions As List(Of String)
        Get
            Return New List(Of String) From {"PdfText", "Image", "Keyword"}
        End Get
    End Property
    ' Public ReadOnly Property ParentOptions As List(Of String) = New List(Of String) From {"", "Root", "Block1"}
    ' Public ReadOnly Property TypeOptions As List(Of String) = New List(Of String) From {"PDFText", "Image", "Keyword"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DataContext = Me

        ' Add any initialization after the InitializeComponent() call.
        AnchorItems = New ObservableCollection(Of AnchorItem) From {
            New AnchorItem With {.Id = 1, .Parent = "", .Type = "PdfText", .Pattern = "Credit Note", .Margin = "-", .Position = "{ X: 242.0, Y: 13.0 }"},
            New AnchorItem With {.Id = 2, .Parent = "", .Type = "PdfText", .Pattern = "BANK DETAILS", .Margin = "-", .Position = "{ X: 20.0, Y: 660.0 }"}
        }

        ConditionItems = New ObservableCollection(Of ConditionItem) From {
            New ConditionItem With {.Name = "FirstPageOfDocument", .Expression = "1"},
            New ConditionItem With {.Name = "LastPageOfDocument", .Expression = "2"}
        }

        FieldItems = New ObservableCollection(Of FieldItem) From {
            New FieldItem With {.Name = "InvoiceId", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText", .Value = "CN-000000238"},
            New FieldItem With {.Name = "CustomerPin", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerName", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText", .Value = "ARK CONSTR"},
            New FieldItem With {.Name = "CustomerHQ", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerAdd", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerPostal", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerExemption", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "DollarPrice", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerHSCode", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "CustomerEmail", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "ReferenceInvoiceId", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "Kralnv", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"},
            New FieldItem With {.Name = "ProductTable", .LA = False, .TA = False, .RA = False, .BA = False, .Type = "PdfText"}
        }


        'Bind data
        AnchorGrid.ItemsSource = AnchorItems
    End Sub


    Private Sub Hyperlink_RequestNavigate(sender As Object, e As RequestNavigateEventArgs)
        Process.Start(New ProcessStartInfo(e.Uri.AbsoluteUri) With {
            .UseShellExecute = True
        })
        e.Handled = True
    End Sub
End Class



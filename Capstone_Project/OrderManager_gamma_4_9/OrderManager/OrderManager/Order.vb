
Public Class Order
    Implements IComparable

    Public id As Long
    Public orderDate As Long
    Public employeeId As Integer
    Public customerId As Integer
    Public tableNum As Integer

    Public Sub New()

    End Sub
    Public Sub New(obj() As Object)
        If obj.Count > 0 Then
            Me.id = obj(0)
            If obj.Count >= 2 Then
                Me.orderDate = obj(1)
                If obj.Count >= 3 Then
                    Me.employeeId = obj(2)
                    If obj.Count >= 4 Then
                        Me.customerId = obj(3)
                        If obj.Count >= 5 Then
                            Me.tableNum = obj(4)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Function ToArray() As Array
        Dim orderTime As DateTime = Date.FromFileTime(Me.orderDate)
        Dim array(4) As String
        array(0) = Me.id.ToString
        array(1) = orderTime.ToShortDateString & " " & orderTime.ToShortTimeString
        Dim employee As Array = DbMysql.Query("select first_name, last_name from employees where id =" & Me.employeeId).Item(0)
        If employee.Length > 0 Then
            Dim employeeName As String = ""
            For Each name In employee
                employeeName &= name
                If employee.Length > 1 Then
                    employeeName &= " "
                End If
            Next
            array(2) = employeeName
        Else
            array(2) = "N/A"
        End If
        Dim customerName As List(Of Array) = DbMysql.Query("select name from customer where id =" & Me.customerId)
        Dim strCustName = "N/A"
        If customerName.Count > 0 Then
            strCustName = customerName.Item(0)(0).ToString
        End If
        array(3) = strCustName
        array(4) = Me.tableNum.ToString
        Return array
    End Function

    Public Shared Function OrderByDate(order1 As Order, order2 As Order) As Integer
        Return order1.CompareDate(order2)
    End Function

    Public Function CompareDate(obj As Object) As Integer Implements IComparable.CompareTo
        Dim thisDate As Integer = 0
        Dim thatDate As Integer = 0
        Dim result As Integer = 0
        If Integer.TryParse(Me.orderDate, thisDate) And Integer.TryParse(CType(obj, Order).orderDate, thatDate) Then
            result = Me.orderDate.CompareTo(thatDate)
        End If
        Return result
    End Function


End Class

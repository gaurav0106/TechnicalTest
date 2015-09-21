Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Assignment4Tests

    <TestMethod()> Public Sub Flatten_ValidArray()

        Dim array = New Char() {"("c, "1"c, "2"c, "3"c, "3"c, ")"c}

        Dim result = Assignment4.Flatten(array)

        CollectionAssert.AreEqual(result, New Char() {"1"c, "2"c, "3"c, "3"c})

    End Sub


    <TestMethod()> Public Sub Flatten_EmptyArray()

        Dim array = New Char() {}

        Dim result = Assignment4.Flatten(array)

        CollectionAssert.AreEqual(result, New Char() {})

    End Sub

End Class
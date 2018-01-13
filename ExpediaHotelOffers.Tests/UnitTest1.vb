Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub GetHotelOffersTest()
        Dim HotOffers As New Models.HotelOffers
        Dim controller As New Data.HotelOffersController

        HotOffers = controller.GetHotelOffers()

        Dim x = 0

    End Sub

    <TestMethod()> Public Sub SearchHotelOffers()
        Dim HotOffers As New Models.HotelOffers
        Dim controller As New Data.HotelOffersController

        HotOffers = controller.GetHotelOffers("miami")
        HotOffers = controller.GetHotelOffers("178293")
        Dim x = 0

    End Sub
End Class
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub GetHotelOffersTest()
        Dim HotOffers As New Models.HotelOffers
        Dim controller As New Data.HotelOffersController
        'test getting all HotelOffers
        HotOffers = controller.GetHotelOffers()

        Dim x = 0

    End Sub

    <TestMethod()> Public Sub SearchHotelOffers()
        Dim HotOffers As New Models.HotelOffers
        Dim controller As New Data.HotelOffersController
        Dim Filter As New Models.HotelOffersFilter
        'test Destination parameter as City
        Filter.Destination = "miami"
        HotOffers = controller.GetHotelOffers(Filter)
        'test Destination parameter as RegionID
        Filter.Destination = "178293"
        HotOffers = controller.GetHotelOffers(Filter)
        Dim x = 0

    End Sub
End Class
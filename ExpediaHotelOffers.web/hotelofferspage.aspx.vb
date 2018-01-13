Public Class hotelofferspage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            BindRepeater()

        End If

    End Sub

    Private Sub BindRepeater(Optional DestinationCity As String = "", Optional StayLength As String = "" _
    , Optional MinStarRating As String = "", Optional MaxStarRating As String = "" _
    , Optional MinGuestRating As String = "", Optional MaxGuestRating As String = "" _
    , Optional MinTotalRate As String = "", Optional MaxTotalRate As String = "" _
    , Optional MinTripStartDate As String = "", Optional MaxTripStartDate As String = "")
        Using HotelController As New Data.HotelOffersController


            Dim HotelOffersList As New Models.HotelOffers

            HotelOffersList = HotelController.GetHotelOffers(DestinationCity, StayLength, MinStarRating, MaxStarRating, MinGuestRating, MaxGuestRating, MinTotalRate, MaxTotalRate, MinTripStartDate, MaxTripStartDate)


            RptHotelOffers.DataSource = HotelOffersList.offers.Hotel
            RptHotelOffers.DataBind()


        End Using
    End Sub

    Private Sub btnSearch_ServerClick(sender As Object, e As EventArgs) Handles btnSearch.ServerClick
        Dim DestinationCity As String = txtDestinationName.Value
        Dim StayLength As String = txtStayLength.Value
        Dim MinStarRating As String = ddlMinStr.SelectedValue
        Dim MaxStarRating As String = ddlMaxStr.SelectedValue
        Dim MinGuestRating As String = ddlMinRate.SelectedValue
        Dim MaxGuestRating As String = ddlMaxRate.SelectedValue
        Dim MinTotalRate As String = txtMinTotalRate.Value
        Dim MaxTotalRate As String = txtMaxTotalRate.Value
        Dim MinTripStartDate As String = dpMinTripDate.Value
        Dim MaxTripStartDate As String = dpMaxTripDate.Value
        BindRepeater(DestinationCity, StayLength, MinStarRating, MaxStarRating, MinGuestRating, MaxGuestRating, MinTotalRate, MaxTotalRate, MinTripStartDate, MaxTripStartDate)
    End Sub
End Class
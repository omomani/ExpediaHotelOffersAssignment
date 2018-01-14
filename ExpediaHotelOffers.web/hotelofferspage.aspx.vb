Public Class hotelofferspage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            BindHotelOffersRepeater()

        End If

    End Sub

    Private Sub BindHotelOffersRepeater(Optional Filter As Models.HotelOffersFilter = Nothing)
        Using HotelController As New Data.HotelOffersController


            Dim HotelOffersList As New Models.HotelOffers
            'Call HotelOffersController where the actual API call exist
            HotelOffersList = HotelController.GetHotelOffers(Filter)

            'Binding
            RptHotelOffers.DataSource = HotelOffersList.offers.Hotel
            RptHotelOffers.DataBind()


        End Using
    End Sub

    Private Sub btnSearch_ServerClick(sender As Object, e As EventArgs) Handles btnSearch.ServerClick
        'Create filter and populate
        Dim Filter As New Models.HotelOffersFilter
        Filter.Destination = txtDestinationName.Value
        Filter.StayLength = txtStayLength.Value
        Filter.MinStarRating = ddlMinStr.SelectedValue
        Filter.MaxStarRating = ddlMaxStr.SelectedValue
        Filter.MinGuestRating = ddlMinRate.SelectedValue
        Filter.MaxGuestRating = ddlMaxRate.SelectedValue
        Filter.MinTotalRate = txtMinTotalRate.Value
        Filter.MaxTotalRate = txtMaxTotalRate.Value
        Filter.MinTripStartDate = dpMinTripDate.Value
        Filter.MaxTripStartDate = dpMaxTripDate.Value
        'Bind repeater
        BindHotelOffersRepeater(Filter)
    End Sub
    Protected Function ResolveRoomsLeft(RoomsLeft As String) As String
        If CInt(RoomsLeft) > 0 Then
            Return RoomsLeft & " rooms left"
        Else
            Return "<font color='red'>sold out</font>"
        End If
    End Function
End Class
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports System.Configuration
Imports ExpediaHotelOffers.Models

Public Class HotelOffersController
    Implements IDisposable
    ''' <summary>
    ''' Public function that consumes the hotel offers API
    ''' It searches among the hotel offers provided by Expedia by passing certain parameters
    ''' </summary>
    ''' <param name="Filter">This parameter is a POCO class that contains all searchable parameters</param>
    ''' <returns>List of HotelOffers</returns>
    Public Function GetHotelOffers(Optional Filter As HotelOffersFilter = Nothing) As HotelOffers
        Dim appId As String = "ExpOffers"

        Dim HotelOffersList As HotelOffers
        Using client As New WebClient()
            'Actual API call
            Dim json As String = client.DownloadString(ResolveHotelOffersAPIURL(Filter))
            'Deserialization of JSON as List of HotelOffers
            HotelOffersList = (New JavaScriptSerializer()).Deserialize(Of HotelOffers)(json)

        End Using
        Return HotelOffersList
    End Function
    ''' <summary>
    ''' Private function to resolve the API URI with the parameters passed as filter
    ''' </summary>
    ''' <param name="Filter"></param>
    ''' <returns>String represents the resolved hotel offers API URI with parameters</returns>
    Private Function ResolveHotelOffersAPIURL(Filter As HotelOffersFilter) As String


        Dim HotelOffersAPIUrl As New StringBuilder
        'Getting API URI from configuration file
        HotelOffersAPIUrl.Append(ConfigurationManager.AppSettings("HotelOffersAPIURL"))

        If Filter IsNot Nothing Then
            'Appending search parameters accordingly
            If Not String.IsNullOrWhiteSpace(Filter.Destination) Then
                If IsNumeric(Filter.Destination) Then
                    HotelOffersAPIUrl.Append("&regionIds=").Append(Filter.Destination.Replace(" ", "+"))
                Else
                    HotelOffersAPIUrl.Append("&destinationCity=").Append(Filter.Destination.Replace(" ", "+"))
                End If

            End If
            If Not String.IsNullOrWhiteSpace(Filter.StayLength) Then
                HotelOffersAPIUrl.Append("&lengthOfStay=").Append(Filter.StayLength.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MinStarRating) Then
                HotelOffersAPIUrl.Append("&minStarRating=").Append(Filter.MinStarRating.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MaxStarRating) Then
                HotelOffersAPIUrl.Append("&maxStarRating=").Append(Filter.MaxStarRating.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MinGuestRating) Then
                HotelOffersAPIUrl.Append("&minGuestRating=").Append(Filter.MinGuestRating.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MaxGuestRating) Then
                HotelOffersAPIUrl.Append("&maxGuestRating=").Append(Filter.MaxGuestRating.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MinTotalRate) Then
                HotelOffersAPIUrl.Append("&minTotalRate=").Append(Filter.MinTotalRate.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MaxTotalRate) Then
                HotelOffersAPIUrl.Append("&maxTotalRate=").Append(Filter.MaxTotalRate.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MinTripStartDate) Then
                HotelOffersAPIUrl.Append("&minTripStartDate=").Append(Filter.MinTripStartDate.Trim)
            End If
            If Not String.IsNullOrWhiteSpace(Filter.MaxTripStartDate) Then
                HotelOffersAPIUrl.Append("&maxTripStartDate=").Append(Filter.MaxTripStartDate.Trim)
            End If
        End If


        Return HotelOffersAPIUrl.ToString
    End Function
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then

            End If

        End If
        disposedValue = True
    End Sub



    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)

    End Sub
#End Region

End Class

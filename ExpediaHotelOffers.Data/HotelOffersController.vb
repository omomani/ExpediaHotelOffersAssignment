Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Public Class HotelOffersController
    Implements IDisposable

    Public Function GetHotelOffers(Optional Destination As String = "", Optional StayLength As String = "" _
    , Optional MinStarRating As String = "", Optional MaxStarRating As String = "" _
    , Optional MinGuestRating As String = "", Optional MaxGuestRating As String = "" _
    , Optional MinTotalRate As String = "", Optional MaxTotalRate As String = "") As Models.HotelOffers
        Dim appId As String = "ExpOffers"
        'Dim url As String = String.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", txtCity.Text.Trim(), appId)
        Dim strUrl As New StringBuilder
        strUrl.Append(String.Format("https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel"))
        If Not String.IsNullOrWhiteSpace(Destination) Then
            If IsNumeric(Destination) Then
                strUrl.Append("&regionIds=").Append(Destination.Replace(" ", "+"))
            Else
                strUrl.Append("&destinationCity=").Append(Destination.Replace(" ", "+"))
            End If

        End If
        If Not String.IsNullOrWhiteSpace(StayLength) Then
            strUrl.Append("&lengthOfStay=").Append(StayLength.Trim)
        End If
        If Not String.IsNullOrWhiteSpace(MinStarRating) Then
            strUrl.Append("&minStarRating=").Append(MinStarRating.Trim)
        End If
        If Not String.IsNullOrWhiteSpace(MaxStarRating) Then
            strUrl.Append("&maxStarRating=").Append(MaxStarRating.Trim)
        End If
        If Not String.IsNullOrWhiteSpace(MinGuestRating) Then
            strUrl.Append("&minGuestRating=").Append(MinGuestRating.Trim)
        End If
        If Not String.IsNullOrWhiteSpace(MaxGuestRating) Then
            strUrl.Append("&maxGuestRating=").Append(MaxGuestRating.Trim)
        End If
        If Not String.IsNullOrWhiteSpace(MinTotalRate) Then
            strUrl.Append("&minTotalRate=").Append(MinTotalRate.Trim)
        End If
        If Not String.IsNullOrWhiteSpace(MaxTotalRate) Then
            strUrl.Append("&maxTotalRate=").Append(MaxTotalRate.Trim)
        End If
        Dim HotelOffersList As Models.HotelOffers
        Using client As New WebClient()
            Dim json As String = client.DownloadString(strUrl.ToString)

            HotelOffersList = (New JavaScriptSerializer()).Deserialize(Of Models.HotelOffers)(json)
            'lblCity_Country.Text = weatherInfo.city.name + "," + weatherInfo.city.country
            'imgCountryFlag.ImageUrl = String.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.city.country.ToLower())
            'lblDescription.Text = weatherInfo.list(0).weather(0).description
            'imgWeatherIcon.ImageUrl = String.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list(0).weather(0).icon)
            'lblTempMin.Text = String.Format("{0}°С", Math.Round(weatherInfo.list(0).temp.min, 1))
            'lblTempMax.Text = String.Format("{0}°С", Math.Round(weatherInfo.list(0).temp.max, 1))
            'lblTempDay.Text = String.Format("{0}°С", Math.Round(weatherInfo.list(0).temp.day, 1))
            'lblTempNight.Text = String.Format("{0}°С", Math.Round(weatherInfo.list(0).temp.night, 1))
            'lblHumidity.Text = weatherInfo.list(0).humidity.ToString()
            'tblWeather.Visible = True
        End Using
        Return HotelOffersList
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

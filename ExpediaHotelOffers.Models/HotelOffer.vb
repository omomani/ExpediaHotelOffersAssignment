Imports System.ComponentModel

Public Class HotelOffers
    Public Property offerInfo As OfferInfo

    Public Property userInfo As UserInfo

    Public Property offers As Offers
End Class
Public Class OfferInfo

    Public Property siteID As String

    Public Property language As String

    Public Property currency As String

    Public Property userSelectedCurrency As String
End Class

Public Class Persona

    Public Property personaType As String
End Class

Public Class UserInfo

    Public Property persona As Persona

    Public Property userId As String
End Class

Public Class OfferDateRange

    Public Property travelStartDate As List(Of Integer)

    Public Property travelEndDate As List(Of Integer)

    Public Property lengthOfStay As Integer
End Class

Public Class Destination

    Public Property regionID As String

    Public Property associatedMultiCityRegionId As String

    Public Property longName As String

    Public Property shortName As String

    Public Property country As String

    Public Property province As String

    Public Property city As String

    Public Property tla As String

    Public Property nonLocalizedCity As String
End Class

Public Class HotelInfo

    Public Property hotelId As String

    Public Property hotelName As String

    Public Property localizedHotelName As String

    Public Property hotelDestination As String

    Public Property hotelDestinationRegionID As String

    Public Property hotelLongDestination As String

    Public Property hotelStreetAddress As String

    Public Property hotelCity As String

    Public Property hotelProvince As String

    Public Property hotelCountryCode As String

    Public Property hotelLatitude As Double

    Public Property hotelLongitude As Double

    Public Property hotelStarRating As String

    Public Property hotelGuestReviewRating As Double

    Public Property hotelReviewTotal As Integer

    Public Property hotelImageUrl As String

    Public Property vipAccess As Boolean

    Public Property isOfficialRating As Boolean
End Class

Public Class HotelUrgencyInfo

    Public Property airAttachRemainingTime As Integer

    Public Property numberOfPeopleViewing As Integer

    Public Property numberOfPeopleBooked As Integer

    Public Property numberOfRoomsLeft As Integer

    Public Property lastBookedTime As Object

    Public Property almostSoldStatus As String

    Public Property link As String

    Public Property airAttachEnabled As Boolean
End Class

Public Class HotelPricingInfo

    Public Property averagePriceValue As Double

    Public Property totalPriceValue As Double

    Public Property crossOutPriceValue As Double

    Public Property originalPricePerNight As Double

    Public Property currency As String

    Public Property percentSavings As Double

    Public Property drr As Boolean
End Class

Public Class HotelUrls

    Public Property hotelInfositeUrl As String

    Public Property hotelSearchResultUrl As String
End Class

Public Class Hotel

    Public Property offerDateRange As OfferDateRange

    Public Property destination As Destination

    Public Property hotelInfo As HotelInfo

    Public Property hotelUrgencyInfo As HotelUrgencyInfo

    Public Property hotelPricingInfo As HotelPricingInfo

    Public Property hotelUrls As HotelUrls
End Class

Public Class Offers


    Public Property Hotel As List(Of Hotel)


End Class


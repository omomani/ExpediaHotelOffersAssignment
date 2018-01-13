<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="hotelofferspage.aspx.vb" Inherits="ExpediaHotelOffers.web.hotelofferspage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Expedia Hotel Offers</title>
  <link href="https://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet"/>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
  <link rel="stylesheet" href="/resources/demos/style.css" />
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
  $( function() {
      $("#dpMinTripDate").datepicker();
      $("#dpMaxTripDate").datepicker();
  });
 
  </script>
</head>
<body style="font-family: 'Open Sans', sans-serif;" >
    <form id="form1" runat="server">
        <br />
        <br />

        <div>
            Hotel Offers
        </div>
        <p>
        <label >Destination:</label>
        <input type="text" runat="server" id="txtDestinationName" />
        <label >Stay Length:</label>
        <input type="text" runat="server" id="txtStayLength" />
        </p>
        <p>Trip start date: From <input type="text" id="dpMinTripDate" size="30" runat="server"/>  no later than <input type="text" id="dpMaxTripDate" size="30" runat="server"/></p>


        <label >Total Rate: Min</label>
        <input type="text" runat="server" id="txtMinTotalRate" />
        <label >Max</label>
        <input type="text" runat="server" id="txtMaxTotalRate" />
        <p>
        <label >Star Rating: Min</label>
        <asp:DropDownList ID="ddlMinStr" runat="server" AutoPostBack="false">
            <asp:ListItem Text="any" Value=""></asp:ListItem>
             <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
            <asp:ListItem Text="5" Value="5"></asp:ListItem>
        </asp:DropDownList>
        
        <label >Max</label>
        <asp:DropDownList ID="ddlMaxStr" runat="server" AutoPostBack="false">
            <asp:ListItem Text="any" Value=""></asp:ListItem>
            <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
            <asp:ListItem Text="5" Value="5"></asp:ListItem>
        </asp:DropDownList>

        </p>
        <label >Guest Rating: Min</label>
        <asp:DropDownList ID="ddlMinRate" runat="server" AutoPostBack="false">
            <asp:ListItem Text="any" Value=""></asp:ListItem>
            <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
            <asp:ListItem Text="5" Value="5"></asp:ListItem>
        </asp:DropDownList>
        
        <label >Max</label>
        <asp:DropDownList ID="ddlMaxRate" runat="server" AutoPostBack="false">
            <asp:ListItem Text="any" Value=""></asp:ListItem>
            <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
            <asp:ListItem Text="5" Value="5"></asp:ListItem>
        </asp:DropDownList>
        
       <p>

        <input type="button" id="btnSearch" value="Search" runat="server"/>
           </p>
        <div>
            <asp:Repeater ID="RptHotelOffers" runat="server">
                <HeaderTemplate>
                    <table cellspacing="0" rules="all" border="1">
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%--       <%# Container.DataItem %>--%>
                            <table>
                                <tr>
                                    <td>
                                        <img height="100" width="100" alt='<%# Eval("HotelInfo.hotelName") %>' title='<%# Eval("HotelInfo.hotelName") %>' src='<%# Eval("HotelInfo.hotelImageUrl") %>' />
                                    </td>
                                    <td style="width: 100%;">
                                        <a href='<%# HttpUtility.UrlDecode(Eval("hotelUrls.hotelInfositeUrl")) %>'>
                                            <asp:Label ID="lblHotelName" runat="server" Text='<%# Eval("HotelInfo.hotelName") %>' />

                                        </a>

                                        <img alt='<%# Eval("HotelInfo.hotelStarRating") %> Star(s)' title='<%# Eval("HotelInfo.hotelStarRating") %> Star(s)' src='icons/stars/<%# Eval("HotelInfo.hotelStarRating") %>.png' />

                                        <div style="float: right;"><b><%# Eval("HotelInfo.hotelGuestReviewRating") %> out of 5</b></div>
                                        <br />
                                        <a href='https://www.google.com/maps/@<%# Eval("HotelInfo.hotelLatitude") %>,<%# Eval("HotelInfo.hotelLongitude") %>,15z'>
                                            <img height="15" width="15" alt='location' title='location' src='icons/loc.png' usemap='https://www.google.com/maps/@<%# Eval("HotelInfo.hotelLatitude") %>,<%# Eval("HotelInfo.hotelLongitude") %>,18' />
                                            <%# Eval("destination.regionID") %>, <%# Eval("destination.city") %> 
                                        
                                        </a>
                                        <div style="float: right;"><%# Eval("HotelInfo.hotelReviewTotal") %> reviews</div>
                                        <br />


                                        <table>
                                            <tr>
                                                <td></td>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>Valid from: <%# Eval("offerDateRange.travelStartDate")(0)%> / <%# Eval("offerDateRange.travelStartDate")(1)%> / <%# Eval("offerDateRange.travelStartDate")(2)%> 
                                                    to: <%# Eval("offerDateRange.travelEndDate")(0)%> / <%# Eval("offerDateRange.travelEndDate")(1)%> / <%# Eval("offerDateRange.travelEndDate")(2)%>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>Avg night price: <font color="red"><strike><%# Eval("hotelPricingInfo.currency") %> <%# Eval("hotelPricingInfo.originalPricePerNight") %></strike></font>  <%# Eval("hotelPricingInfo.currency") %>  <%# Eval("hotelPricingInfo.averagePriceValue") %>
                                                            </td>

                                                        </tr>
                                                        <tr>
                                                            <td>Total price for <%# Eval("offerDateRange.lengthOfStay")%> night(s): <%# Eval("hotelPricingInfo.currency") %> <%# Eval("hotelPricingInfo.totalPriceValue") %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>


                        </td>

                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
    <script>
        $('#dpMinTripDate').datepicker({ dateFormat: 'yy-mm-dd' }).val();
        $('#dpMaxTripDate').datepicker({ dateFormat: 'yy-mm-dd' }).val();
    </script>
</body>
</html>
